Feature: KatalonShopping
	As a user of Katalon shopping website
	I would like to add and remove items to the cart
	So that I can verify my shopping list

@ShoppingCartTest
Scenario: To verify if users can add or remove items from the cart
	Given I add four random items to my cart.
	When I view my cart.
	Then I find total four items listed in my cart.
	When I search for the lowest price item.
	And I am able to remove the lowest price item from my cart.
	Then I am able to verify three items in my cart.