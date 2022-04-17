using AventStack.ExtentReports;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;


namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {
        private static ExtentReports extent;

        [BeforeScenario]
        public void Setup()
        {
            // Launch the browser
            Initialize();

            // Referencing to an excel file and sheet name
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            // Call the SignIn class
            SignIn.SigninStep();

            // Wait for the page to load properly
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Languages')]", 5);
        }

        [AfterScenario]
        public void TearDown()
        {

            // Taking a screenshot
            string img = SaveScreenShotClass.SaveScreenshot(driver, "Report");
            var extent = new ExtentReports();
            var test = extent.CreateTest("ReportScreenshot");
            test.Log(Status.Info, "Snapshot below: " + test.AddScreenCaptureFromPath(img));

            //Close the browser
            Close();

            // end test. (Reports)
            //CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            // CommonMethods.Extent.Flush();
        }
    }
}
