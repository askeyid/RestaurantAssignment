Feature: Checkout Calculation
    In order to provide accurate bills
    As a customer
    I want the system to correctly calculate the total bill for a group of people

@regression
Scenario: Expected System returns a correctly calculated bill for a group of 4 people
	When Order 4 starters, 4 mains and 4 drinks
	Then The endpoint returns a correctly calculated bill of 54.00

@regression
Scenario: Expected System returns a correctly calculated bill for a mixed time order
    A group of 2 people order 1 starter and 2 mains and 2 drinks before 19:00. The bill is requested and the correct amount is shown on the bill.
    The group of two people are then joined by 2 more people at 20:00 who order 2 mains and 2 drinks, when the party is ready to leave the final bill is requested and is correct.
    When Order 1 starters, 2 mains and 2 drinks before 19:00
    Then The endpoint returns a correctly calculated bill of 21.50
	When Order 0 starters, 2 mains and 2 drinks
    Then The endpoint returns a correctly calculated bill of 40.50

@regression
Scenario: Expected System re-calculates a bill when canceling a part of order
    A group of 4 people order a starter, 1 mains and a drink each. The bill is requested and correctly calculated. 
    A member of the group cancels their order and the order is now updated to reflect one member of the party leaving.  
    A final bill is requested as the party is ready to leave and final amount is correct and reflects the changes to the group.
    When Order 4 starters, 4 mains and 4 drinks
    Then The endpoint returns a correctly calculated bill of 54.00
    When Cancel 1 starter, 1 main and 1 drink
    Then The endpoint returns a correctly calculated bill of 40.50
