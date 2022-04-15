using MarsQA_1.Pages;
using MarsQA_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class Task1_ProfileStepDefinitions : CommonDriver
    {
        // Initializing page objects
        HomePage homePageObj = new HomePage();
        LogIn logInObj = new LogIn();


        [Given(@"I logged into Mars website successfully")]
        public void GivenILoggedIntoMarsWebsiteSuccessfully()
        {
            // Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Go to Mars website and SignIn page
            homePageObj.GoToSignInPage(driver);

            // SignIn to website
            logInObj.LogInSteps(driver);
        }

        [Then(@"close test run")]
        public void ThenCloseTestRun()
        {
            driver.Quit();
        }

        [Given(@"I logged into Mars website successfully_")]
        public void GivenILoggedIntoMarsWebsiteSuccessfully_()
        {
            // Do nothing
        }

        [When(@"I add a profile skill entry_")]
        public void WhenIAddAProfileSkillEntry_()
        {
            // Do nothing
        }

        [Then(@"the skill entry should be added successfully_")]
        public void ThenTheSkillEntryShouldBeAddedSuccessfully_()
        {
            // Do nothing
        }

        [When(@"I add a profile education entry_")]
        public void WhenIAddAProfileEducationEntry_()
        {
            // Do nothing
        }

        [Then(@"the education entry should be added successfully_")]
        public void ThenTheEducationEntryShouldBeAddedSuccessfully_()
        {
            // Do nothing
        }

        [When(@"I add a profile certification entry_")]
        public void WhenIAddAProfileCertificationEntry_()
        {
            // Do nothing
        }

        [Then(@"the certification entry should be added successfully_")]
        public void ThenTheCertificationEntryShouldBeAddedSuccessfully_()
        {
            // Do nothing
        }

        [When(@"I add a profile language entry")]
        public void WhenIAddAProfileLanguageEntry()
        {
            // Do nothing
        }

        [Then(@"the language entry should be added successfully")]
        public void ThenTheLanguageEntryShouldBeAddedSuccessfully()
        {
            // Do nothing
        }

        [When(@"I enter a profile description")]
        public void WhenIEnterAProfileDescription()
        {
            // Do nothing
        }

        [Then(@"the description should be entered successfully")]
        public void ThenTheDescriptionShouldBeEnteredSuccessfully()
        {
            // Do nothing
        }

        [When(@"I enter a profile first and last name")]
        public void WhenIEnterAProfileFirstAndLastName()
        {
            // Do nothing
        }

        [Then(@"the first and last name should be entered successfully")]
        public void ThenTheFirstAndLastNameShouldBeEnteredSuccessfully()
        {
            // Do nothing
        }

        [When(@"I enter a profile location")]
        public void WhenIEnterAProfileLocation()
        {
            // Do nothing
        }

        [Then(@"the location should be entered successfully")]
        public void ThenTheLocationShouldBeEnteredSuccessfully()
        {
            // Do nothing
        }

        [When(@"I enter a profile availability")]
        public void WhenIEnterAProfileAvailability()
        {
            // Do nothing
        }

        [Then(@"the availability should be entered successfully")]
        public void ThenTheAvailabilityShouldBeEnteredSuccessfully()
        {
            // Do nothing
        }

        [When(@"I enter a profile hours")]
        public void WhenIEnterAProfileHours()
        {
            // Do nothing
        }

        [Then(@"the hours should be entered successfully")]
        public void ThenTheHoursShouldBeEnteredSuccessfully()
        {
            // Do nothing
        }

        [When(@"I enter a profile earn target")]
        public void WhenIEnterAProfileEarnTarget()
        {
            // Do nothing
        }

        [Then(@"the earn target should be entered successfully")]
        public void ThenTheEarnTargetShouldBeEnteredSuccessfully()
        {
            // Do nothing
        }

        [Then(@"close browser")]
        public void ThenCloseBrowser()
        {
            // Do nothing
        }
    }
}