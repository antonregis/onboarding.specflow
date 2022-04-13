using MarsQA_1.Pages;
using MarsQA_1.Utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class ProfileEducationStepDefinitions : CommonDriver
    {
        // Initializing page objects
        ProfileEducation profileEduPageObj = new ProfileEducation();


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
    }
}
