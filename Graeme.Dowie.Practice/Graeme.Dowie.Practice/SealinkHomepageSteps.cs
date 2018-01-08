using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using TechTalk.SpecFlow;

namespace Graeme.Dowie.Practice
{
    [Binding]
    public class SealinkHomepageSteps
    {
        [Given(@"user has visited the Sealink Homepage")]
        public void GivenUserHasVisitedTheSealinkHomepage()
        {
            SeleniumHelper.SetUpDriver();
        }

        [Then(@"user should see the top navigation menu (.*)")]
        public void ThenUserShouldSeeTheTopNavigationMenu(string topNavMenu)
        {
            var navMenu = SeleniumHelper.WebDriver.FindElement(By.Id("myNavbar"));
            Assert.Contains(topNavMenu, navMenu.Text);
        }

        [Then(@"user should be able to see the footer menu (.*)")]
        public void ThenUserShouldBeAbleToSeeTheFooterMenu(string footMenu)
        {
            var menuFooter = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".menu-footer"));
            Assert.Contains(footMenu, menuFooter.Text);
        }


        [When(@"clicks on the where are you going dropdown")]
        public void WhenClicksOnTheWhereAreYouGoingDropdown()
        {
            var whereAreYouGoing = SeleniumHelper.WebDriver.FindElement(By.CssSelector(".where-are-you-going-group"));
            whereAreYouGoing.Click();
        }

        [Then(@"all booking destinations should be visible (.*)")]
        public void ThenAllBookingDestinationsShouldBeVisible(string bookDestination)
        {
            var bookingDropDown = SeleniumHelper.WebDriver.FindElement(By.CssSelector("#booking-form > div > div.col-md-4.col-fw > div > ul")).Text;
            Assert.Contains(bookDestination, bookingDropDown);
        }

    }
}
