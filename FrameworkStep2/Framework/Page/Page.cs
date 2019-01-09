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
        private const string WARNING_CHILD = "*Если на момент совершения полета несовершеннолетний не достигнет указанного возраста, он не будет допущен к посадке на борт самолета.";

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group form-group--flight-search']//div[@class='form-input origin']")]
        private IWebElement departureCity;
        [FindsBy(How = How.XPath, Using = "//div[@class='form-group form-group--flight-search']//div[@class='form-input destination']")]
        private IWebElement destinationCity;
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Вы должны выбрать один из вариантов')]")]
        private IWebElement errorMessage;
        [FindsBy(How = How.XPath, Using = "//input[@id='inputGoing']")]
        private IWebElement buttonDepatureDate;
        [FindsBy(How = How.XPath, Using = "//label[@for='roundTrip']")]
        private IWebElement buttonRoundTrip;
        [FindsBy(How = How.XPath, Using = "//td[contains(@class,'ui-datepicker-current-day ui-datepicker-today')]")]
        private IWebElement depatureDate;
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-datepicker-group ui-datepicker-group-first')]//tbody//tr[2]//td[3]")]
        private IWebElement depatureDatePast;
        [FindsBy(How = How.XPath, Using = "//td[@class='travelTime ui-datepicker-travel-time']//a[@class='ui-state-default'][contains(text(),'15')]")]
        private IWebElement destinationDate;
        [FindsBy(How = How.XPath, Using = "//td[@class='travelTime ui-datepicker-travel-time']//a[@class='ui-state-default'][contains(text(),'8')]")]
        private IWebElement destinationDatePast;
        [FindsBy(How = How.XPath, Using = "//a[@title='След>']")]
        private IWebElement nextPageCalendar;
        [FindsBy(How = How.XPath, Using = "//a[@class='ui-state-default ui-state-hover']")]
        private IWebElement destinationDateOneYear;
        [FindsBy(How = How.XPath, Using = "//ul[@class='passengers-popup_main']//li[1]//div[2]//span[1]")]
        private IWebElement reducePassengers;
        [FindsBy(How = How.XPath, Using = "//ul[@class='passengers-popup_main']//li[1]//div[2]//span[2]")]
        private IWebElement addPassengers;
        [FindsBy(How = How.XPath, Using = "//div[@class='popover popover--error']//div[@class='popover-content'][contains(text(),'Вы должны заполнить это поле')]")]
        private IWebElement errorPassengers;
        [FindsBy(How = How.XPath, Using = "//ul[@class='passengers-popup_main']//li[2]//div[2]//span[1]")]
        private IWebElement reduceChildren;
        [FindsBy(How = How.XPath, Using = "//ul[@class='passengers-popup_main']//li[2]//div[2]//span[2]")]
        private IWebElement addChildren;
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'*Если на момент совершения полета несовершеннолетн')]")]
        private IWebElement warningChildren;
        [FindsBy(How = How.XPath, Using = "//ul[@class='passengers-popup_main']//li[3]//div[2]//span[1]")]
        private IWebElement reduceBaby;
        [FindsBy(How = How.XPath, Using = "//ul[@class='passengers-popup_main']//li[3]//div[2]//span[2]")]
        private IWebElement addBaby;
        [FindsBy(How = How.XPath, Using = "//span[@class='vy-icon-baby']//span[@class='path4']")]
        private IWebElement warningBaby;
        [FindsBy(How = How.XPath, Using = "//button[@id='btnSubmitHomeSearcher']")]
        private IWebElement findButton;
        [FindsBy(How = How.XPath, Using = "//div[@id='home-body_1-box4']")]
        private IWebElement groupFlight;

        public IWebElement DepartureCity { get => departureCity; set => departureCity = value; }
        public IWebElement DestinationCity { get => destinationCity; set => destinationCity = value; }
        public IWebElement ErrorMessage { get => errorMessage; set => errorMessage = value; }
        public IWebElement ButtonDepatureDate { get => buttonDepatureDate; set => buttonDepatureDate = value; }
        public IWebElement ButtonRoundTrip { get => buttonRoundTrip; set => buttonRoundTrip = value; }
        public IWebElement DepatureDate { get => depatureDate; set => depatureDate = value; }
        public IWebElement DepatureDatePast { get => depatureDatePast; set => depatureDatePast = value; }
        public IWebElement DestinationDate { get => destinationDate; set => destinationDate = value; }
        public IWebElement DestinationDatePast { get => destinationDatePast; set => destinationDatePast = value; }
        public IWebElement NextPageCalendar { get => nextPageCalendar; set => nextPageCalendar = value; }
        public IWebElement DestinationDateOneYear { get => destinationDateOneYear; set => destinationDateOneYear = value; }
        public IWebElement ReducePassengers { get => reducePassengers; set => reducePassengers = value; }
        public IWebElement AddPassengers { get => addPassengers; set => addPassengers = value; }
        public IWebElement ErrorPassengers { get => errorPassengers; set => errorPassengers = value; }
        public IWebElement ReduceChildren { get => reduceChildren; set => reduceChildren = value; }
        public IWebElement AddChildren { get => addChildren; set => addChildren = value; }
        public IWebElement WarningChildren { get => warningChildren; set => warningChildren = value; }
        public IWebElement ReduceBaby { get => reduceBaby; set => reduceBaby = value; }
        public IWebElement AddBaby { get => addBaby; set => addBaby = value; }
        public IWebElement WarningBaby { get => warningBaby; set => warningBaby = value; }
        public IWebElement FindButton { get => findButton; set => findButton = value; }
        public IWebElement GroupFlight { get => groupFlight; set => groupFlight = value; }
        
        public PageHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
        }
        //1
        public bool EnterTheDateRetroactively(IWebElement depatureDatePast)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            destinationCity.SendKeys(DESTATION_CITY);
            if (depatureDatePast.Enabled)
            {
                depatureDatePast.Click();
                return false;
            }
            else return true;
        }
        //2
        public void ChoiceNeedingMonth()
        {
            for (int i = 0; i < 10; i++)
            {
                nextPageCalendar.Click();
            }
        }
        
        public bool EnterReturnDateOneYearAfterDeparture(IWebElement destinationDateOneYear)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            destinationCity.SendKeys(DESTATION_CITY);
            buttonRoundTrip.Click();
            depatureDate.Click();
            ChoiceNeedingMonth();
            if (destinationDateOneYear.Enabled)
            {
                destinationDateOneYear.Click();
                return true;
            }
            else return false;
        }
        //3
        public bool ChoiceDepartureDateWithoutDestinationDate(IWebElement destationDate)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            destinationCity.SendKeys(DESTATION_CITY);
            buttonRoundTrip.Click();
            depatureDate.Click();
            if (!destinationDate.Enabled)
            {
                return true;
            }
            else return false;
        }
        //4
        public string EnterOnlyOneAirport(IWebElement errorMessage)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            findButton.Click();
            if (errorMessage.Enabled)
            {
                return errorMessage.Text;
            }
            else return "No";
        }
        //5
        public string ChoiceOfChildWithoutAdultAsPassenger(IWebElement warningChildren)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            destinationCity.SendKeys(DESTATION_CITY);
            buttonRoundTrip.Click();
            depatureDate.Click();
            destinationDate.Click();
            reducePassengers.Click();
            addChildren.Click();
            if (warningChildren.Enabled)
            {
                return warningChildren.Text;
            }
            else return "No";
        }
        //6
        public string ChoiceFlightParametrs(IWebElement errorPassengers)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            destinationCity.SendKeys(DESTATION_CITY);
            buttonRoundTrip.Click();
            depatureDate.Click();
            destinationDate.Click();
            ReducePassengers.Click();
            findButton.Click();
            if (errorPassengers.Enabled)
            {
                return errorPassengers.Text;
            }
            else return "No";
        }
        //7
        public bool ChoiceBabyWithoutAdultAsPassenger(IWebElement addBaby)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            destinationCity.SendKeys(DESTATION_CITY);
            buttonRoundTrip.Click();
            depatureDate.Click();
            destinationDate.Click();
            ReducePassengers.Click();
            if (addBaby.Enabled)
            {
                addBaby.Click();
                return true;
            }
            else return false;
        }
        //8
        public void EnterTwentyFivePassengers()
        {
            for (int i = 0; i< 25; i++)
            {
                addPassengers.Click();
            }
        }

        public bool ChoiceTwentyFivePassengers(IWebElement groupFlight)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            destinationCity.SendKeys(DESTATION_CITY);
            buttonRoundTrip.Click();
            depatureDate.Click();
            destinationDate.Click();
            EnterTwentyFivePassengers();
            if (groupFlight.Enabled)
            {
                return true;
            }
            else return false;
        }
        //9
        public string AirportDepartureAndDestinationCannotBeSamePlace(IWebElement errorMessage)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            departureCity.SendKeys(Keys.Enter);
            destinationCity.SendKeys(DEPARTURE_CITY);
            departureCity.SendKeys(Keys.Enter);
            findButton.Click();
            if (errorMessage.Enabled)
            {
                return errorMessage.Text;
            }
            else return "No";

        }
        //10
        public bool EnterTheNumberOfBabiesMoreThanNumberOfAdults(IWebElement addBaby)
        {
            departureCity.SendKeys(DEPARTURE_CITY);
            destinationCity.SendKeys(DESTATION_CITY);
            buttonRoundTrip.Click();
            depatureDate.Click();
            destinationDate.Click();
            ReducePassengers.Click();
            findButton.Click();
            addBaby.Click();
            if (addBaby.Enabled)
            {
                addBaby.Click();
                return true;
            }
            else return false;
        }
    }
}
