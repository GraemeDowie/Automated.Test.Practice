using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;


namespace NBA.Practice.Tests.Steps
{
    [Binding]
    public class HomePageNBASteps
    {
        [Then(@"the (.*) should be visible")]
        public void ThenTheShouldBeVisible(string mainNavigationLinks)
        {
            var mainNav = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#gms-partner-header"));
            Assert.Contains(mainNavigationLinks, mainNav.Text);
        }

        [Then(@"user should see the latest featured articles")]
        public void ThenUserShouldSeeTheLatestFeaturedArticles()
        {
            var featuredArticles = SeleniumHelper.WebDriver.FindElements(By.CssSelector("#gms-trending > .gms-feature"));
            Assert.True(featuredArticles.Count >= 6);
        }


    }
}
