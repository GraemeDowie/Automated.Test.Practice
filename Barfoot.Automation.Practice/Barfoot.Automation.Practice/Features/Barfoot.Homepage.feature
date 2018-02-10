Feature: Barfoot Homepage Test Examples
A selection of Automated tests of the homepage for Barfoot&T

Background: User has visited the Barfoot homepage on desktop
	Given user has visited the Barfoot homepage

Scenario Outline: User can see the top navbar options 
	Then user can see the top nav bar options <topNavOptions>

Examples: 
	| topNavOptions       |
	| Buy                 |
	| Sell                |
	| Rent                |
	| Commercial          |
	| Projects            |
	| Property Management |
	| Body Corporate      |
	| About us            |
	| Careers             |
	| Market reports      |
	| News                |
	| Find us             |


Scenario: User selects Auckland City from the region tab then performs a search
	When User selects Auckland City from the region tab
		| regionAC      |
		| Auckland City |
		And presses the search button 
	Then User should see returned property results for Auckland City
