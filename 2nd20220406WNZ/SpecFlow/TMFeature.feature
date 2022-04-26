Feature: TMFeature

As a TurnUp portal tester
I would like to create, edit and delete time and material records
So that I can manage time and materials successfully


Scenario: [create time and material record with valid values]
	Given [I logged into turn up portal successfully]
	When [I navigate to Time and Material page]
	When [I create a new time and material record]
	Then [the record should be created successfully]

Scenario Outline: [edit time and material record with valid values]
	Given [I logged into turn up portal successfully]
	When [I navigate to Time and Material page]
	When [I update '<Description>,'<Code>'and'<Price>' on an existing time and material record]
	Then [the record should have the updated '<Description>','<Code>'and'<Price>'

	Examples: 
	| Destription  | Code      | Price |
	| Time         | Walter    | 20    |
	| Material     | GodSpirit | 100   |
	| EditedRecord | God       | 666   |


	
