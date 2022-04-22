Feature: TMFeature

As a TurnUp portal tester
I would like to create, edit and delete time and material records
So that I can manage time and materials successfully

@tag1
Scenario: [create time and material record with valid values]
	Given [I logged into turn up portal successfully]
	When [I navigate to Time and Material page]
	When [I create a new time and material record]
	Then [the record should be created successfully]
