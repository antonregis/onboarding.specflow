using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;


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

            // Referencing to an excel file and sheet name
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Education");

            // Enter institute name
            IWebElement instituteTextbox = driver.FindElement(By.XPath("//*[@name='instituteName']"));
            instituteTextbox.SendKeys(ExcelLibHelper.ReadData(2, "Institute"));

            // Select country of school
            string strXpathCountry = String.Format("//option[contains(text(),'{0}')]", ExcelLibHelper.ReadData(2, "Country"));
            IWebElement countryOfinstituteOption = driver.FindElement(By.XPath(strXpathCountry));
            countryOfinstituteOption.Click();

            // Select title of degree
            string strXpathTitle = String.Format("//option[contains(text(),'{0}')]", ExcelLibHelper.ReadData(2, "Title"));
            IWebElement titleOption = driver.FindElement(By.XPath(strXpathTitle));
            titleOption.Click();

            // Enter Degree
            IWebElement degreeTextbox = driver.FindElement(By.XPath("//*[@name='degree']"));
            degreeTextbox.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));

            // Select year of graduation
            string strXpathGraduationYear = String.Format("//option[contains(text(),'{0}')]", ExcelLibHelper.ReadData(2, "Year"));
            IWebElement yearOfGraduationOption = driver.FindElement(By.XPath(strXpathGraduationYear));
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