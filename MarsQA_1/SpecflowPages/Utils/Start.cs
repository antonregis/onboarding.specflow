using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;


        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(ConstantHelpers.ReportsPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featurecontext)
        {
            // ExtentReport: Create test or the Feature
            featureName = extent.CreateTest<Feature>(featurecontext.FeatureInfo.Title);  
        }

        [AfterStep]
        public void AfterEachStep(ScenarioContext scenariocontext)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (scenariocontext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            
            if (scenariocontext.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
            }
        }

        [BeforeScenario]
        public void Setup(ScenarioContext scenarioContext)
        {
            // Launch the browser
            Initialize();

            // ExcelDataReader NotSupportedException fix: Enable encoding 1252 for .NET Core
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Referencing to an excel file and sheet name
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelSigninDataPath, "Credentials");

            // Call the SignIn class
            SignIn.SigninStep();

            // Wait for the page to load properly
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Languages')]", 8);

            // ExtentReport: Create node or the Scenario
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void TearDownScenario()
        {
            // Takes a screenshot
            string img = SaveScreenShotClass.SaveScreenshot(driver, "Screenshot");
            
            // Attaching screenshot to report
            scenario.AddScreenCaptureFromPath(img);

            //Close the browser
            driver.Quit();
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }
    }
}