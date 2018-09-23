Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	When I press add btn 1
	Then the result should be 120 on the screen

@open_weatherzone
Scenario: OPening wewatherzone webpage	
	Given I have opened the browser
	When i enter the weatherzone url and press go
	Then the weatherzone webpage is displayed

@check_address
Scenario: enter in postcode for weather
	Given I am on the weatherzone website
	When i enter a postcode 3000 in the search field
	Then the weather for 'Melbourne' is displayed

Scenario: log into the age
Given i have opened the website
