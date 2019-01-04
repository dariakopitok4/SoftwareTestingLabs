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
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-week-end ")]
        private IWebElement depatureDatePast;
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-week-end ui-datepicker-first-day travelTime ui-datepicker-travel-time")]
        private IWebElement destinationDate;
        [FindsBy(How = How.Id, Using = "icon vy-icon-rounded-les")]
        private IWebElement reducePassengers;
        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        private IWebElement findButton;
        [FindsBy(How = How.Id, Using = "popover-content")]
        private IWebElement errorMessage;
        [FindsBy(How = How.Id, Using = "icon vy-icon-rounded-more-2")]
        private IWebElement selectAmountOfBaby;
        [FindsBy(How = How.ClassName, Using = "imageBox box-roundedr")]
        private IWebElement groupFlight;
        [FindsBy(How = How.Id, Using = "icon vy-icon-rounded-more")]
        private IWebElement selecNumOfChildren; 
        
        public IWebElement DepartureBox { get => departureCity; }
        public IWebElement DestinationBox { get => destinationCity; }
        public IWebElement ButtonRoundTrip { get => buttonRoundTrip; }
        public IWebElement DepatureDate { get => depatureDate; }
        public IWebElement DepatureDatePast { get => depatureDate; }
        public IWebElement DestinationDate { get => destinationDate; }
        public IWebElement ReducePassengers { get => reducePassengers; }
        public IWebElement FindButton { get => findButton; }
        public IWebElement ErrorMess { get => errorMessage; }
        public IWebElement SelectAmountOfBaby { get => selectAmountOfBaby; }
        public IWebElement GroupFlight { get => groupFlight; }

        public void SelectMoreThenOneBaby()
        {
            selectAmountOfDifferentPassenger.Click();
            selectAmountOfBaby.Click();
            selectMoreThenOneBabyForOneAdult.Click();
        }

        public string GetErrorMess()
        {
            return errorMessage.GetAttribute("content");
        }

        public void IndependentFlightForChildrenUnderTwelveYearsOld()
        {
            returnDate.Click();
            departureDate.Click();
            selectSingleYouthPerson.Click();
            findButton.Click();
            selectFlightThere.Click();
            selectFlightHere.Click();
            buttonNext.Click();
            selectYearOfBirth.Click();
        }

        public string GetYearOfBirth()
        {
            return selectYearOfBirth.GetAttribute("content");
        }

        public void ChooseNumberOfPassengers()
        {
            selecNumOfAdultsPeople.Click();
            selecNumOfYouthsPeople.Click();
        }

        public string GetErrorAboutNumberOfPassengers()
        {
            return errorMaxCountOfPeople.GetAttribute("content");
        }

        public void ChooseZeroCountOfPassengers()
        {
            selectZeroPessangers.Click();
        }

        public string GetErrorAboutZeroCountOfPassengers()
        {
            return ErrorMinCountOfPeople.GetAttribute("content");
        }

        public void ChoosePessangerWichNeedSpecialHelp()
        {
            returnDate.Click();
            departureDate.Click();
            selectSingleYouthPerson.Click();
            findButton.Click();
            selectFlightThere.Click();
            selectFlightHere.Click();
            buttonNext.Click();
            selectYearOfBirth.Click();
        }

        public string GetPessangerWichNeedSpecialHelp()
        {
            return personNeedSpecialHelp.GetAttribute("content");
        }

        public void ChoosePossibilityToTransferDataToThirdFace()
        {
            returnDate.Click();
            departureDate.Click();
            selectSingleYouthPerson.Click();
            findButton.Click();
            selectFlightThere.Click();
            selectFlightHere.Click();
            buttonNext.Click();
            selectYearOfBirth.Click();
        }

        public string GetPossibilityToTransferDataToThirdFace()
        {
            return dataTransferToThirdFace.GetAttribute("content");
        }



        public PageHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
        }
        
        public void SelectDateOfDepartureAndDateOfReturn()
        {
            departureDate.Click();
            returnDate.Click();
        }

        public string SelectRightDateOfReturn()
        {
            return rightDateOfReturn.GetAttribute("content");
        }

        public void SelectEqualAirportOfDepartureAndReturn(string destAirport, string departAirport)
        {
            destinationAirport.SendKeys(destAirport);
            departureAirport.SendKeys(departAirport);
        }

        public string ErrorMessAboutNotEqualAirportOfDepartureAndReturn()
        {
            return errorMessAirportOfDepartureAndArrivalNotCoincide.GetAttribute("content");
        }

        public void SelectPastDateOfDepartureAndReturn()
        {
            departureDatePast.Click();
            returnDate.Click();
        }

        public string SelectRightDateOfReturnAndDeparture()
        {
            return rightDateOfdeaparture.GetAttribute("content");
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
