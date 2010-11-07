Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have a calculator

Scenario: Ten plus nine equals 19
	Given I have entered 10 into the calculator
	And I have entered 9 into the calculator
	When I press add
	Then the result should be 19 on the screen

Scenario: One plus two plus three equals 6
	Given I have entered 1 into the calculator
	And I have entered 2 into the calculator
	And I have entered 3 into the calculator
	When I press add
	Then the result should be 6 on the screen