using MarsQA_1.Pages;
using MarsQA_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class ProfileSkillStepDefinitions : CommonDriver
    {
        // Initializing page objects
        HomePage homePageObj = new HomePage();
        SignIn signInObj = new SignIn();
        ProfileSkill profileSkillPageObj = new ProfileSkill();


        [Given(@"I logged into Mars website successfully")]
        public void GivenILoggedIntoMarsWebsiteSuccessfully()
        {
            // Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Go to Mars website and SignIn page
            homePageObj.GoToSignInPage(driver);

            // SignIn to website
            signInObj.SignInSteps(driver);
        }

        [When(@"I add a profile skill entry")]
        public void WhenIAddAProfileSkillEntry()
        {
            // Add skill entry
            profileSkillPageObj.AddSkill(driver);
        }

        [Then(@"the skill entry should be added successfully")]
        public void ThenTheSkillEntryShouldBeAddedSuccessfully()
        {
            // Get entered skill & level
            string enteredSkill = profileSkillPageObj.GetSkill(driver);
            string enteredLevel = profileSkillPageObj.GetLevel(driver);

            // Assertion
            Assert.That((enteredSkill == "Skill1"), "Failed: Skill mismatch");
            Assert.That((enteredLevel == "Intermediate"), "Failed: Level mismatch");
        }

        [Then(@"close test run")]
        public void ThenCloseTestRun()
        {
            driver.Quit();
        }
    }
}
