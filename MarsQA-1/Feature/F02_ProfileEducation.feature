Feature: F02_ProfileEducation

As a seller, I want the feature to add my Profile Education so that 
the people seeking for some skills can look into my details.


Scenario: Add profile education entry
	Given I logged into Mars website successfully
	When I add a profile education entry
	Then the education entry should be added successfully
	Then close test run