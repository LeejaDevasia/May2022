Feature: TMFeature

A short summary of the feature

@create
Scenario: 1 create time and material with valid details
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	And I create time and material record
	Then the record should be created successfully

	@edit
Scenario Outline: 2 edit existing time and material record
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	And I update '<Description>','<Code>','<Price>' on an existing time and material record
	Then the record should have updated '<Description>','<Code>','<Price>'

	Examples: 
	| Description | Code | Price   |
	| FirstEdit   | 001  | $12.00  |
	| SecondEdit  | 002  | $15.00  |
	| ThirdEdit   | 003  | $200.00 |


	@delete
Scenario: 3 delete an existing time and material record
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	And I deleted an existing time and material record
	Then the record should have deleted succesfully