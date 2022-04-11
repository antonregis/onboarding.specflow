using MarsQA_1.Pages;
using MarsQA_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        // Initializing page objects
        HomePage homePageObj = new HomePage();
        SignIn signInObj = new SignIn();
        ProfileSkill profileSkillPageObj = new ProfileSkill();
        ProfileEducation profileEduPageObj = new ProfileEducation();
        ProfileCertification profileCertPageObj = new ProfileCertification();


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



        [When(@"I add a profile education entry")]
        public void WhenIAddAProfileEducationEntry()
        {
            // Add education entry
            profileEduPageObj.AddEducation(driver);
        }

        [Then(@"the education entry should be added successfully")]
        public void ThenTheEducationEntryShouldBeAddedSuccessfully()
        {
            // Get entered education entry
            string enteredCountry = profileEduPageObj.GetCountry(driver);
            string enteredInsitute = profileEduPageObj.GetInstitute(driver);
            string enteredTitle = profileEduPageObj.GetTitle(driver);
            string enteredDegree = profileEduPageObj.GetDegree(driver);
            string enteredGraduationYear = profileEduPageObj.GetGraduationYear(driver);

            // Assertion
            Assert.That((enteredCountry == "New Zealand"), "Failed: Country mismatch");
            Assert.That((enteredInsitute == "AUT"), "Failed: Institute mismatch");
            Assert.That((enteredTitle == "Associate"), "Failed: Title mismatch");
            Assert.That((enteredDegree == "Test Analyst"), "Failed: Degree mismatch");
            Assert.That((enteredGraduationYear == "2022"), "Failed: Year of graduation mismatch");
        }



        [When(@"I add a profile certification entry")]
        public void WhenIAddAProfileCertificationEntry()
        {
            // Add certification entry
            profileCertPageObj.AddCertification(driver);
        }

        [Then(@"the certification entry should be added successfully")]
        public void ThenTheCertificationEntryShouldBeAddedSuccessfully()
        {
            // Get entered certification entry
            string enteredCertificate = profileCertPageObj.GetCertficate(driver);
            string enteredFrom = profileCertPageObj.GetFrom(driver);
            string enteredYear = profileCertPageObj.GetYear(driver);

            // Assertion
            Assert.That((enteredCertificate == "Certified Tester Foundation Level"), "Failed: Certificate mismatch");
            Assert.That((enteredFrom == "ISTQB"), "Failed: Certified From mismatch");
            Assert.That((enteredYear == "2022"), "Failed: Year mismatch");
        }
    }
}