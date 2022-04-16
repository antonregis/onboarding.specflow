using MarsQA_1.Helpers;
using OpenQA.Selenium;


namespace MarsQA_1.Pages
{
    public static class SignIn
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("//INPUT[@name='email']"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@name='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
        public static void SigninStep()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2,"username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            LoginBtn.Click();            
        }
    }
}