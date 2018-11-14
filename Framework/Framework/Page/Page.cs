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

namespace Framework
{
    class PageHome
    {
        private const string url = "https://www.vueling.com/ru";
        private const string cityDestination = "Barcelona";
        private const string cityDeparture = "Madrid";

        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "form-input origin")]
        private IWebElement destinationBox;
        [FindsBy(How = How.ClassName, Using = "form-input destination")]
        private IWebElement departureBox;
        [FindsBy(How = How.Id, Using = "roundTrip")]
        private IWebElement buttonFlightBack;
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-week-end ")]
        private IWebElement destinationDate;
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-week-end ui-datepicker-first-day travelTime ui-datepicker-travel-time")]
        private IWebElement departureDate;
        [FindsBy(How = How.Id, Using = "icon vy-icon-rounded-les")]
        private IWebElement reducePassengers;
        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        private IWebElement findButton;
        [FindsBy(How = How.Id, Using = "popover-content")]
        private IWebElement errorMess;

        public IWebElement DestinationBox { get => destinationBox; }
        public IWebElement DepartureBox { get => departureBox; }
        public IWebElement FindButton { get => findButton; }
        public IWebElement ErrorMess { get => errorMess; }

        public PageHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ChoiceFlightParametrs()
        {
            destinationBox.SendKeys(cityDestination);
            departureBox.SendKeys(cityDeparture);
            buttonFlightBack.Click();
            destinationDate.Click();
            departureDate.Click();
            reducePassengers.Click();
            findButton.Click();
        }

        public string GetErrorMes()
        {
            return errorMess.GetAttribute("content");
        }
    }
}
