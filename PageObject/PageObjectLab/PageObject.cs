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
        const string city = "Madrid";
        const string notFind = "Вы должны выбрать один из вариантов";
        const string url = "https://www.vueling.com/ru";

        [Test]
        public void page()
        {
            driver.Navigate().GoToUrl(url);
            PageHome pageHome = new FindElements();
            PageFactory.InitElements(driver, pageHome);
            pageHome.destinationBox.SendKeys(city);
            pageHome.departureBox.SendKeys(city);
            pageHome.findButton.Click();

            Assert.AreEqual(notFind, pageHome.errorMess.Text);
        }
    }
}