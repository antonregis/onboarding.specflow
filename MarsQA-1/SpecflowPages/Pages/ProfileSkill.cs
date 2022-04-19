using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;


namespace MarsQA_1.Pages
{
    internal class ProfileSkill
    {
        public void AddSkill(IWebDriver Driver)
        {
            // Click Skill button
            IWebElement skillButton = Driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            skillButton.Click();

            // Click Add New button
            IWebElement addNewButton = Driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            // Referencing to an excel file and sheet name
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelDataPath, "Skill");

            // Enter Skill
            IWebElement addSkillTextbox = Driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            addSkillTextbox.SendKeys(ExcelLibHelper.ReadData(2, "Skill"));

            // Select Skill level option]
            string strXpathLevel = String.Format("//option[contains(text(),'{0}')]", ExcelLibHelper.ReadData(2, "Level"));
            IWebElement skillLevelOption = Driver.FindElement(By.XPath(strXpathLevel));
            skillLevelOption.Click();

            // Click Add button
            IWebElement addButton = Driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
            addButton.Click();

            // Wait for entered Skill to be visible
            Wait.WaitToBeVisible(Driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
        }

        public string GetSkill(IWebDriver Driver) 
        {
            IWebElement enteredSkill = Driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return enteredSkill.Text;
        }

        public string GetLevel(IWebDriver Driver)
        {
            IWebElement enteredLevel = Driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return enteredLevel.Text;
        }
    }
}