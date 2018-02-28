Feature: PlayerIndex
	As a user
	When I click on the players link in the main nav
	Then I should see an alphabetical list of players and player details

Background: User has visited the UK NBA site using a desktop and clicks on the Players link in the top nav
	Given User has visited the NBA website on desktop
	When user clicks on the players link on the top nav


Scenario: User should be on the player index page and see a list of players and information
	Then user should see a players index list


Scenario: User should see that all Player index data is visible
	Then all player index data should be visible


Scenario: User selects a team then all player index data should be for the team selected
	When user selects a team from the dropdown list
	Then all players should be for the team selected
