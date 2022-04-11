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
    internal class ProfileSkill
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
    }
}