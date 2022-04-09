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
    internal class SignIn
    {
        public void SignInSteps(IWebDriver driver)
        {
            try
            { 
                // Identify email textbox and enter valid email
                IWebElement emailTextbox = driver.FindElement(By.XPath("//INPUT[@name='email']"));
                emailTextbox.SendKeys("anton.regis@gmail.com");

                // Identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("//INPUT[@name='password']"));
                passwordTextbox.SendKeys("Passw0rd");

                // Identify log in button and click
                IWebElement loginButton = driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
                loginButton.Click();

                // Wait for Languages button to load
                Wait.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Languages')]", 4);
            }
            catch (Exception ex)
            {
                Assert.Fail("Failed: Login unsuccessful", ex.Message);
                throw;
            }
        }
    }
}
