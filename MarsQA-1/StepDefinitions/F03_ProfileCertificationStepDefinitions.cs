using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;


namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class F03_ProfileCertificationStepDefinitions : Driver
    {
        // Initializing page objects
        ProfileCertification profileCertPageObj = new ProfileCertification();


        [Given(@"I add a profile certification entry")]
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