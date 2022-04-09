using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    internal class HomePage
    {
        public void GoToSignInPage(IWebDriver driver)
        {
            // Launch Mars website SignIn
            driver.Navigate().GoToUrl("http://localhost:5000");

            // Load SignIn page or popup
            IWebElement signInButton = driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
            signInButton.Click();
        }
    }
}
