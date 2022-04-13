Feature: ProfileSkill

As a seller, I want the feature to add my Profile Skill so that 
the people seeking for some skills can look into my details.


Scenario: Add profile skill entry
	Given I logged into Mars website successfully
	When I add a profile skill entry
	Then the skill entry should be added successfully
	Then close test run