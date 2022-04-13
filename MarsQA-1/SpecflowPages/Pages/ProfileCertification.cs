﻿using MarsQA_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    internal class ProfileCertification
    {
        public void AddCertification(IWebDriver driver)
        {
            // Click Certifications button
            IWebElement certificationsButton = driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
            certificationsButton.Click();

            // Click Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButton.Click();

            // Enter Certificate or award
            IWebElement certificateTextbox = driver.FindElement(By.XPath("//*[@name='certificationName']"));
            certificateTextbox.SendKeys("Certified Tester Foundation Level");

            // Enter Certified from 
            IWebElement certifiedFromTextbox = driver.FindElement(By.XPath("//*[@name='certificationFrom']"));
            certifiedFromTextbox.SendKeys("ISTQB");

            // Select year of completion
            IWebElement yearOfCompletionOption = driver.FindElement(By.XPath("//option[contains(text(),'2022')]"));
            yearOfCompletionOption.Click();

            // Click Add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@value='Add']"));
            addButton.Click();

            // Wait for entered Certificate to be visible
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
        }

        public string GetCertficate(IWebDriver driver)
        {
            IWebElement enteredCertificate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return enteredCertificate.Text;
        }

        public string GetFrom(IWebDriver driver)
        {
            IWebElement enteredFrom = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return enteredFrom.Text;
        }

        public string GetYear(IWebDriver driver)
        {
            IWebElement enteredYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            return enteredYear.Text;
        }
    }
}