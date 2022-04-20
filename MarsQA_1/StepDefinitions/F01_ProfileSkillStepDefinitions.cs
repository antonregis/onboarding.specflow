using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;


namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class F01_ProfileSkillStepDefinitions : Driver
    {
        // Initializing page objects
        ProfileSkill profileSkillPageObj = new ProfileSkill();

        [Given(@"I add a profile skill entry")]
        public void GivenIAddAProfileSkillEntry()
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
    }
}