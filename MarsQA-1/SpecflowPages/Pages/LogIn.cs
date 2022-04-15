using MarsQA_1.Helpers;
using MarsQA_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    internal class LogIn
    {
        public void LogInSteps(IWebDriver driver)
        {
            try
            {
                // Referencing to an excel file and sheet name
                ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

                // Identify email textbox and enter valid email
                IWebElement emailTextbox = driver.FindElement(By.XPath("//INPUT[@name='email']"));
                emailTextbox.SendKeys(ExcelLibHelper.ReadData(2, "username"));

                // Identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("//INPUT[@name='password']"));
                passwordTextbox.SendKeys(ExcelLibHelper.ReadData(2, "password"));

                // Identify log in button and click
                IWebElement loginButton = driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
                loginButton.Click();

                // Wait for Languages button to load
                Wait.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Languages')]", 5);
            }
            catch (Exception ex)
            {
                Assert.Fail("Failed: Login unsuccessful", ex.Message);
                throw;
            }
        }
    }
}
