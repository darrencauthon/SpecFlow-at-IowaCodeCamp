Feature: Promotion
	In order to get free prizes
	As the customer
	I want to enter my promotion code and see if I've won

Scenario: Customer enters a winning code
	Given I entered the following values into the promotion form
	| Field         | Value            |
	| FirstName     | John             |
	| LastName      | Galt             |
	| Email         | test@testing.com |
	| PromotionCode | test1234         |
	And the following promotions exist
	| PromotionCode  | Prize        |
	| test1234       | A free coke. |
	When I submit my promotion form
	Then I should be sent to the Confirmation page
	And the prize name 'A free coke.' should be passed to the next page
	And the name 'John Galt' and the email 'test@testing.com' and the promotion code 'test1234' should be passed to the prize winning recorder

Scenario: Customer enters a non-winning code
	Given I entered the following values into the promotion form
	| Field         | Value          |
	| PromotionCode | a failing code |
	And the following promotions exist
	| PromotionCode  | Prize        |
	| test1234       | A free coke. |
	When I submit my promotion form
	Then I should be sent to the Failure page
	And my information should not be recorded as a win
