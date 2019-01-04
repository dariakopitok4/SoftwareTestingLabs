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
        private const string URL = "https://www.vueling.com/ru";
        private const string DEPARTURE_CITY = "Barcelona";
        private const string DESTATION_CITY = "Madrid";

        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "form-input origin")]
        private IWebElement departureCity;
        [FindsBy(How = How.ClassName, Using = "form-input destination")]
        private IWebElement destinationCity;
        [FindsBy(How = How.Id, Using = "roundTrip")]
        private IWebElement buttonRoundTrip;
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-week-end ")]
        private IWebElement depatureDate;
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-week-end ui-datepicker-first-day travelTime ui-datepicker-travel-time")]
        private IWebElement destinationDate;
        [FindsBy(How = How.Id, Using = "icon vy-icon-rounded-les")]
        private IWebElement reducePassengers;
        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        private IWebElement findButton;
        [FindsBy(How = How.Id, Using = "popover-content")]
        private IWebElement errorMessage;
        
        public IWebElement DepartureBox { get => departureCity; }
        public IWebElement DestinationBox { get => destinationCity; }
        public IWebElement ButtonRoundTrip { get => buttonRoundTrip; }
        public IWebElement DepatureDate { get => depatureDate; }
        public IWebElement DestinationDate { get => destinationDate; }
        public IWebElement ReducePassengers { get => reducePassengers; }
        public IWebElement FindButton { get => findButton; }
        public IWebElement ErrorMess { get => errorMessage; }

        public PageHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
        }

        public void ChoiceFlightParametrs()
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            destinationCity.SendKeys(DESTATION_CITY);
            buttonRoundTrip.Click();
            depatureDate.Click();
            destinationDate.Click();
            ReducePassengers.Click();
            findButton.Click();
        }

        public string GetErrorMes()
        {
            return errorMessage.GetAttribute("content");
        }
    }
}
