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
    internal class ProfileEducation
    {
        public void AddEducation(IWebDriver driver)
        {
            // Click Education button
            IWebElement educationButton = driver.FindElement(By.XPath("//a[contains(text(),'Education')]"));
            educationButton.Click();

            // Click Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewButton.Click();

            // Enter institute name
            IWebElement instituteTextbox = driver.FindElement(By.XPath("//*[@name='instituteName']"));
            instituteTextbox.SendKeys("AUT");

            // Select country of school
            IWebElement countryOfinstituteOption = driver.FindElement(By.XPath("//option[contains(text(),'New Zealand')]"));
            countryOfinstituteOption.Click();

            // Select title of degree
            IWebElement titleOption = driver.FindElement(By.XPath("//option[contains(text(),'Associate')]"));
            titleOption.Click();

            // Enter Degree
            IWebElement degreeTextbox = driver.FindElement(By.XPath("//*[@name='degree']"));
            degreeTextbox.SendKeys("Test Analyst");

            // Select year of graduation
            IWebElement yearOfGraduationOption = driver.FindElement(By.XPath("//option[contains(text(),'2022')]"));
            yearOfGraduationOption.Click();

            // Click Add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@value='Add']"));
            addButton.Click();

            // Wait for entered Country to be visible
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
        }

        public string GetCountry(IWebDriver driver)
        {
            IWebElement enteredCountry = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return enteredCountry.Text;
        }

        public string GetInstitute(IWebDriver driver)
        {
            IWebElement enteredInsitute = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return enteredInsitute.Text;
        }

        public string GetTitle(IWebDriver driver)
        {
            IWebElement enteredTitle = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
            return enteredTitle.Text;
        }

        public string GetDegree(IWebDriver driver)
        {
            IWebElement enteredDegree = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
            return enteredDegree.Text;
        }
        
        public string GetGraduationYear(IWebDriver driver)
        {
            IWebElement enteredGraduationYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]"));
            return enteredGraduationYear.Text;
        }
    }
}