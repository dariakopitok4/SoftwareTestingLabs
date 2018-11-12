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

namespace WebDriverT
{
    class Testclass
    {
        public IWebDriver driver;
        string city = "Madrid";
        string notFind = "Вы должны выбрать один из вариантов";

        [Test]
        public void page()
        {
            driver.Navigate().GoToUrl("https://www.vueling.com/ru");
            FindElements pageHome = new FindElements(); // чтобы могли обращаться к объектам из PageHome.cs
            PageFactory.InitElements(driver, pageHome); // инициализация элементов Page Object из PageHome.cs
            pageHome.destinationBox.SendKeys(city);
            pageHome.departureBox.SendKeys(city);
            pageHome.findButton.Click();

            Assert.AreEqual(notFind, pageHome.errorMess.Text);

        }
    }
}