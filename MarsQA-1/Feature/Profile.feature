Feature: Task1_Profile

As a seller, I want the feature to add my Profile Details so that 
the people seeking for some skills can look into my details.


Scenario: TC01_Add profile skill entry
	Given I logged into Mars website successfully_
	When I add a profile skill entry_
	Then the skill entry should be added successfully_

Scenario: TC02_Add profile education entry
	When I add a profile education entry_
	Then the education entry should be added successfully_

Scenario: TC03_Add profile certification entry
	When I add a profile certification entry_
	Then the certification entry should be added successfully_

Scenario: TC04_Add profile language entry
	When I add a profile language entry
	Then the language entry should be added successfully

Scenario: TC05_Enter profile description
	When I enter a profile description
	Then the description should be entered successfully

Scenario: TC06_Enter profile first and last name
	When I enter a profile first and last name
	Then the first and last name should be entered successfully

Scenario: TC07_Enter profile location
	When I enter a profile location
	Then the location should be entered successfully

Scenario: TC08_Enter profile availability
	When I enter a profile availability
	Then the availability should be entered successfully

Scenario: TC09_Enter profile hours
	When I enter a profile hours
	Then the hours should be entered successfully

Scenario: TC10_Enter profile earn target
	When I enter a profile earn target
	Then the earn target should be entered successfully
	Then close browser