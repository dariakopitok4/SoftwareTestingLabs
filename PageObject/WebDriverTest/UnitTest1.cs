using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectPattern
{
    [TestFixture]
    public class PageObjectPattern
    {
        string valueCity = "Madrid";
        public IWebDriver Driver { get; set; }


        [TestCase]
        public void Test_enter_one_destination()
        {
            this.Driver = new ChromeDriver();
            this.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [Test]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }
        [Test]
        public void Search()
        {
            MainPage Page = new MainPage(this.Driver);
            Page.Navigate();
            Page.Search(valueCity);
        }
        }
    }
