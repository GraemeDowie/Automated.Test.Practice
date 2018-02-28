Feature: HomePageNBA
	As a user 
	When I visit the nba.com homepage
	I want to be able to see the latest news stories, scores and navigation for the site

Background: User has visited the NBA homepage on desktop
	Given User has visited the NBA website on desktop

Scenario Outline: User can see the main site navigation links
	Then the <mainNavigationLinks> should be visible

Examples: 
	| mainNavigationLinks                       |
	| NEWS                                      |
	| VIDEO                                     |
	| SCORES                                    |
	| SCHEDULE                                  |
	| DRAFT                                     |
	| STANDINGS                                 |
	| PLAYOFFS                                  |
	| TEAMS                                     |
	| PLAYERS                                   |
	| DAILY FANTASY                             |
	| STATS & MORE                              |
	| Official online NBA destination in the UK |

Scenario: User should see the latest featured articles
	Then user should see the latest featured articles
