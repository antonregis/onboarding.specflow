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
    internal class ProfilePage
    {
        public void AddSkill(IWebDriver driver)
        {
            // Click Skill button
            IWebElement skillButton = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            skillButton.Click();

            // Click Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            // Enter Skill
            IWebElement addSkillTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            addSkillTextbox.SendKeys("Skill1");

            // Select Skill level option
            IWebElement skillLevelOption = driver.FindElement(By.XPath("//option[contains(text(),'Intermediate')]"));
            skillLevelOption.Click();

            // Click Add button
            IWebElement addButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
            addButton.Click();

            // Wait for entered Skill to be visible
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
        }

        public string GetSkill(IWebDriver driver) 
        {
            IWebElement enteredSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return enteredSkill.Text;
        }

        public string GetLevel(IWebDriver driver)
        {
            IWebElement enteredLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return enteredLevel.Text;
        }

        
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