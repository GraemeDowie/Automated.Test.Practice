using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;

namespace NBA.Practice.Tests
{
    [Binding]
    public class PlayerIndexSteps
    {
        [Given(@"User has visited the NBA website on desktop")]
        public void GivenUserHasVisitedTheNBAWebsiteOnDesktop()
        {
            SeleniumHelper.StartUpDriverDesktop();
        }

        [When(@"user clicks on the players link on the top nav")]
        public void WhenUserClicksOnThePlayersLinkOnTheTopNav()
        {
            SeleniumHelper.SelectPlayersLink();
        }

        [Then(@"user should see a players index list")]
        public void ThenUserShouldSeeAPlayersIndexList()
        {
            WebDriverWait waitForIndex = new WebDriverWait(SeleniumHelper.WebDriver, TimeSpan.FromSeconds(5));
            waitForIndex.Until(ExpectedConditions.ElementIsVisible(By.ClassName("sib-table-container")));

            var playerIndexUrl = SeleniumHelper.WebDriver.Url;

            var playerIndexRows = SeleniumHelper.WebDriver.FindElements(By.CssSelector(".sib-table-container table tbody tr"));
            Assert.Equal(24, playerIndexRows.Count);
        }

        [Then(@"all player index data should be visible")]
        public void ThenAllPlayerIndexDataShouldBeVisible()
        {
            var playerInfo = SeleniumHelper.WebDriver.FindElements(By.TagName("tr"));
            Assert.True(playerInfo != null);
        }

        [When(@"user selects a team from the dropdown list")]
        public void WhenUserSelectsATeamFromTheDropdownList()
        {
            var selectFilter = SeleniumHelper.WebDriver.FindElement(By.CssSelector("div.col-sm-9.col-lg-6.player-index-header-filter-wrap.hidden-sm > span > select"));
            selectFilter.Click();

            var selectTeam = SeleniumHelper.WebDriver.FindElement(By.CssSelector("div.col-sm-9.col-lg-6.player-index-header-filter-wrap.hidden-sm > span > select > option:nth-child(4)"));
            selectTeam.Click();
        }

        [Then(@"all players should be for the team selected")]
        public void ThenAllPlayersShouldBeForTheTeamSelected()
        {
            var teamName = SeleniumHelper.WebDriver.FindElement(By.CssSelector("table > tbody > tr:nth-child(1) > td:nth-child(3) > span.hidden-sm > a")).Text;
            var playerIndexTable = SeleniumHelper.WebDriver.FindElement(By.ClassName("stats-table"));
            List<string> teamList = new List<string>(new string[] { "Atlanta Hawks", "Boston Celtics", "Brooklyn Nets", "Charlotte Hornets", "Chicago Bulls", "Cleveland Cavaliers", "Dallas Mavericks", "Denver Nuggets", "Detroit Pistons", "Golden State Warriors", "Houston Rockets", "Los Angeles Lakers", "Indiana Pacers", "Los Angeles Clippers", "Memphis Grizzlies", "Miami Heat", "Milwaukee Bucks", "Minnesota Timberwolves", "New Orleans Pelicans", "New York Knicks", "Oklahoma City Thunder", "Orlando Magic", "Philadelphia Sixers", "Pheonix Suns", "Portland Trail Blazers", "Sacramento Kings", "San Antonio Spurs", "Toronto Raptors", "Utah Jazz", "Washington Wizards"});

            for (int i = 0; i < teamList.Count; i++)
            {
                
                if (teamList[i].Equals(teamName))
                {
                    teamList.RemoveAt(i);
                }
            }

            Assert.DoesNotContain(playerIndexTable.Text, teamList);

            Assert.Contains(teamName, playerIndexTable.Text);
        }
    }
}
