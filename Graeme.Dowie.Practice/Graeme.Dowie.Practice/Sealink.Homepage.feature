Feature: Sealink Homepage

Background: User has visited the Sealink Homepage on desktop
	Given user has visited the Sealink Homepage

Scenario Outline: Top Navigation is visible
	Then user should see the top navigation menu <topNavMenu>

Examples: 
	| topNavMenu           |
	| Book                 |
	| Timetables and fares |
	| Destinations         |
	| Travelling with us   |
	
Scenario Outline: Footer Menu is visible
	Then user should be able to see the footer menu <footMenu>

Examples: 
	| footMenu                         |
	| Book                             |
	| Booking informtation             |
	| Travel alerts                    |
	| Manage your booking              |
	| Timetables                       |
	| Waiheke timetables & fares       |
	| Great Barrier timetables & fares |
	| Rakino timetable & fares         |
	| Destinations                     |
	| Discover Waiheke                 |
	| Discover Great Barrier           |
	| Discover Rakino                  |
	| Discover Pine Harbour            |
	| Travelling with us               |
	| Our Ferries                      |
	| Delays & cancellations           |
	| Dangerous goods                  |
	| Our ferry terminals              |
	| Onboard facilities               |
	| Baggage, bikes & pets            |
	| Company Information              |
	| About us                         |
	| Work for us                      |
	| Terms & conditions               |
	| Feedback                         |
	| Privacy policy                   |
	| Sponsorship                      |


Scenario Outline: User clicks on the booking form dropdown then all options should be visible
	When clicks on the where are you going dropdown
	Then all booking destinations should be visible <bookDestination>

Examples: 
	| bookDestination |
	| Auckland        |
	| Waiheke         |
	| Waiheke         |
	| Auckland        |
	| Auckland        |
	| Great Barrier   |
	| Great Barrier   |
	| Auckland	      |