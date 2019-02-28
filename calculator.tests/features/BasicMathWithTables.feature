Feature: BasicMathWithTables
	In order to avoid silly mistakes
	As an arithmetic novice
	I want to perform basic math operations in bulk

@mytag
Scenario: Add two numbers
	Given I have entered the following data into a calculator
	| Value1 | Value2 |
	| 5      | 10     |
	| 11     | 12     |
	When I press add after each set
	Then the calculator should show
	| Value |
	| 15    |
	| 23    |
