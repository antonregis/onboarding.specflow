﻿Feature: ProfileCertification

As a seller, I want the feature to add my Profile Certification so that 
the people seeking for some skills can look into my details.


Scenario: Add profile certification entry
	Given I logged into Mars website successfully
	When I add a profile certification entry
	Then the certification entry should be added successfully
	Then close test run