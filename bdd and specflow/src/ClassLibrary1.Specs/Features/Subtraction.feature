Feature: Subtraction
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have a calculator

Scenario: Subtract two numbers
	Given I have entered 100 into the calculator
	And I have entered 70 into the calculator
	When I press subtract
	Then the result should be 30 on the screen

Scenario: Testing1234
	Given I have a person with the following values
	| Field     | Value     |
	| FirstName | Darren    |
	| LastName  | Cauthon   |
