using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Barfoot.Automation.Practice
{
    [Binding]
    public class BarfootHomepageTestExamplesSteps
    {
        [Given(@"user has visited the Barfoot homepage")]
        public void GivenUserHasVisitedTheBarfootHomepage()
        {
            SeleniumHelper.SetUpDriver();
        }
        
        [Then(@"user can see the top nav bar options (.*)")]
        public void ThenUserCanSeeTheTopNavBarOptions(string topNavOptions)
        {
            var navBar = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".navbar"));
            Assert.Contains(topNavOptions, navBar.Text);
        }

        [When(@"User selects Auckland City from the region tab")]
        public void WhenUserSelectsAucklandCityFromTheRegionTab(Table table)
        {
            var selectRegion = SeleniumHelper.WebDriver.FindElement(By.Id("canvas_0_SearchResidentialForm_uxSelectedRegionRegions"));
            selectRegion.Click();

            var selectAckCity = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#canvas_0_SearchResidentialForm_uxSelectedRegionRegions > optgroup:nth-child(2) > option:nth-child(1)"));
            selectAckCity.Click();

            var regionAck = table.CreateInstance<RegionAC>();

            var ackCitySelected = SeleniumHelper.WebDriver.FindElement(By.Id("canvas_0_SearchResidentialForm_uxSelectedRegion")).GetAttribute("value");
            Assert.Equal(regionAck.regionAC, ackCitySelected);
        }

        [When(@"presses the search button")]
        public void WhenPressesTheSearchButton()
        {
            SeleniumHelper.StartSearch();
        }

        [Then(@"User should see returned property results for Auckland City")]
        public void ThenUserShouldSeeReturnedPropertyResultsForAucklandCity()
        {
            var pageURL = SeleniumHelper.WebDriver.Url;
            Assert.Contains("residential&region=Auckland+City", pageURL);

            var searchHeading = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#content > div > h1"));
            Assert.Equal("Houses and Sections for Sale in Auckland City", searchHeading.Text);

            var results = SeleniumHelper.WebDriver.FindElement(By.Id("canvas_2_uxResultsPaginationFooter_uxTotalCount"));

            var totalResults = Int32.Parse(results.Text);

            var nextButton = SeleniumHelper.WebDriver.FindElement(By.Id("canvas_2_uxResultsPaginationFooter_uxNext")).GetCssValue("border-color");

            if (totalResults > 50)
            {
                Assert.Equal("rgb(0, 153, 223)", nextButton); 
            }
            else
            {
                Assert.Equal("rgb(204,204,204)", nextButton);
            }
        }

    }
}
