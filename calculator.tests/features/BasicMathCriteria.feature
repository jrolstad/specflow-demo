Feature: Basic Math
	In order to avoid silly mistakes
	As an arithmetic novice
	I want to perform basic math operations

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Subtract two numbers
	Given I have entered 50 into the calculator
	And I have entered 30 into the calculator
	When I press subtract
	Then the result should be 20 on the screen

Scenario: Multiply two numbers
	Given I have entered 5 into the calculator
	And I have entered 3 into the calculator
	When I press multiply
	Then the result should be 15 on the screen

Scenario: Divide two numbers
	Given I have entered 15 into the calculator
	And I have entered 3 into the calculator
	When I press divide
	Then the result should be 5 on the screen
