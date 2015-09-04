@Fundao
Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Calculadora
Background: 
	Given A Calculator

Scenario: Add two numbers
#Arrange
	And I have entered 50 into the calculator
	And I have entered 70 into the calculator
#Act
	When I press add
#Assert
	Then the result should be 120 on the screen

#Triangulation
	Given I have entered 50 into the calculator
	When I press add
	Then the result should be 170 on the screen

	Given I have entered 200 into the calculator
	When I press subtract
	Then the result should be 30 on the screen

Scenario: Add Operation
	Given I have entered 15 into the calculator
	Given I have entered 5 into the calculator
	When I press add
	Then the result should be 20 on the screen

Scenario: Subtract Operation
	Given I have entered 15 into the calculator
	Given I have entered 35 into the calculator
	When I press subtract
	Then the result should be 20 on the screen

Scenario: Multiply Operation
	Given I have entered 10 into the calculator
	Given I have entered 5 into the calculator
	When I press multiply
	Then the result should be 50 on the screen

Scenario: Divide Operation
	Given I have entered 10 into the calculator
	Given I have entered 60 into the calculator
	When I press divide
	Then the result should be 6 on the screen
