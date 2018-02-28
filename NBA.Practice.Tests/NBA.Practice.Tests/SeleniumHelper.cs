using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Practice.Tests
{
    class SeleniumHelper
    {
        private static IWebDriver _webdriver;
        public static IWebDriver WebDriver
        {
            get
            {
                if (_webdriver == null)
                {
                    _webdriver = new ChromeDriver();
                }
                return _webdriver;
            }
        }

        public static IWebDriver StartUpDriverDesktop()
        {
            WebDriver.Url = "http://www.nba.com";
            WebDriver.Manage().Window.Maximize();

            return WebDriver;
        }

        public static IWebDriver StartUpDriverMobileIPhoneX()
        {
            WebDriver.Url = "http://www.nba.com";
            WebDriver.Manage().Window.Size = new System.Drawing.Size(375, 812);

            return WebDriver;
        }

        public static void SelectPlayersLink()
        {
            var selectPlayersLink = WebDriver.FindElement(By.CssSelector("#gms-partner-header > div > nav > ul > li:nth-child(9) > a"));
            selectPlayersLink.Click();
        }

        
    }
}
