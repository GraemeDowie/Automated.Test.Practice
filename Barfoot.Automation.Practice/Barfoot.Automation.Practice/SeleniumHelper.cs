using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Barfoot.Automation.Practice
{
    class SeleniumHelper
    {
        private static IWebDriver _iwebdriver;
        public static IWebDriver WebDriver
        {
            get
            {
                if (_iwebdriver == null)
                {
                    _iwebdriver = new ChromeDriver();
                }
                return _iwebdriver;
            }
        }

        public static IWebDriver SetUpDriver()
        {
            WebDriver.Url = "https://www.barfoot.co.nz/";

            WebDriver.Manage().Window.Maximize();
            return WebDriver;
        }

        public static void StartSearch()
        {
            var startSearch = WebDriver.FindElement(By.CssSelector(".btn-block"));
            startSearch.Click();
        }
    }
}
