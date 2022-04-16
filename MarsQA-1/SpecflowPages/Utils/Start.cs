using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using TechTalk.SpecFlow;


namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

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

            // Screenshot
            // string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            // test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            // test.Log(Status.Info, "Snapshot below: " + test.AddScreenCaptureFromPath(img));
            
            
            //Close the browser
            Close();

            // end test. (Reports)
            //CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            // CommonMethods.Extent.Flush();


        }
    }
}
