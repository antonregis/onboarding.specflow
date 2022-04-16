using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace MarsQA_1.Helpers
{
    public class Wait
    {
        // Implicit wait
        public static void TurnOnWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        // Explicit wait
        public static void WaitToBeClickable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            else if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

            else if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }

            else
            {
                Console.WriteLine(" ■  ■  ■ No Wait locator value! ■  ■  ■ ");
            }
        }

        internal static void TurnOnWait()
        {
            throw new NotImplementedException();
        }

        public static void WaitToBeVisible(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }


            else if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }

            else if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
            }

            else
            {
                Console.WriteLine(" ■  ■  ■ No Wait locator value! ■  ■  ■ ");
            }

        }
    }
}
