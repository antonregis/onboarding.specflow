using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace MarsQA_1.Helpers
{
    public class Driver
    {
        // Initialize the browser
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {
            // Open and maximise chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); 
        }

        public static string BaseUrl
        {
            get { return ConstantHelpers.Url; }
        }

        // Go to home page
        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        //Close the browser
        public void Close()
        {
            driver.Quit();
        }
    }
}