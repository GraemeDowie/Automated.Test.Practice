using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Graeme.Dowie.Practice
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

        public static IWebDriver SetUpDriver()
        {
            WebDriver.Url = "http://sealink.co.nz";

            WebDriver.Manage().Window.Maximize();
            return WebDriver;
        }
    }
}
