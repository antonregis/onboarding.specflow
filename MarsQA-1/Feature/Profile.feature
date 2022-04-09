Feature: Profile

As a seller, I want the feature to add my Profile Details so that 
the people seeking for some skills can look into my details.


Scenario: TC01 Add profile skill entry
	Given I logged into Mars website successfully
	When I add a profile skill entry
	Then the skill entry should be added successfully

Scenario: TC02 Add profile education entry
	When I add a profile education entry
	Then the education entry should be added successfully

Scenario: TC03 Add profile certification entry
	When I add a profile certification entry
	Then the certification entry should be added successfully

Scenario: TC04 Add profile language entry
	When I add a profile language entry
	Then the language entry should be added successfully

Scenario: TC05 Enter profile description
	When I enter a profile description
	Then the description should be entered successfully

Scenario: TC06 Enter profile first and last name
	When I enter a profile first and last name
	Then the first and last name should be entered successfully

Scenario: TC07 Enter profile location
	When I enter a profile location
	Then the location should be entered successfully

Scenario: TC08 Enter profile availability
	When I enter a profile availability
	Then the availability should be entered successfully

Scenario: TC09 Enter profile hours
	When I enter a profile hours
	Then the hours should be entered successfully

Scenario: TC10 Enter profile earn target
	When I enter a profile earn target
	Then the earn target should be entered successfully
	Then close test run