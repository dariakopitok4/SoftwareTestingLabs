using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Security.Policy;
using System.Threading;

namespace PageObjectLab
{
    class TestClass
    {
        public IWebDriver driver;
        private const string CITY = "Madrid";
        private const string NOT_FOUND = "Вы должны выбрать один из вариантов";
        private const string URL = "https://www.vueling.com/ru";

        [Test]
        public void SelectTwoEqualCity()
        {
            driver.Navigate().GoToUrl(URL);
            PageHome pageHome = new PageHome();
            PageFactory.InitElements(driver, pageHome);
            pageHome.departureBox.SendKeys(CITY);
            pageHome.destinationBox.SendKeys(CITY);
            pageHome.findButton.Click();

            Assert.AreEqual(NOT_FOUND, pageHome.errorMessage.Text);
        }
    }
}