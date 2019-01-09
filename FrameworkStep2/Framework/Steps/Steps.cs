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
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Instance.GetInstance();
        }

        public void CloseBrowser()
        {
            Instance.CloseBrowser();
        }

        public bool SelectDateRetroactively()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.EnterTheDateRetroactively(mainPage.DepatureDatePast);
        }

        public bool SelectReturnDateOneYearAfterDeparture()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.EnterReturnDateOneYearAfterDeparture(mainPage.DestinationDateOneYear);
        }

        public bool SelectDepartureDateWithoutDestinationDate()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.ChoiceDepartureDateWithoutDestinationDate(mainPage.DepatureDate);
        }

        public string SelectOnlyOneAirport()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.EnterOnlyOneAirport(mainPage.ErrorMessage);
        }

        public string SelectChildWithoutAdult()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.ChoiceOfChildWithoutAdultAsPassenger(mainPage.WarningChildren);
        }

        public string SelectFlightParametrs()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.ChoiceFlightParametrs(mainPage.ErrorPassengers);
        }

        public bool SelectBabyWithoutAdultAsPassenger()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.ChoiceBabyWithoutAdultAsPassenger(mainPage.AddBaby);
        }

        public bool SelectTwentyFivePassengers()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.ChoiceTwentyFivePassengers(mainPage.GroupFlight);
        }

        public string SelectAirportDepartureAndDestinationCannotBeSamePlace()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.AirportDepartureAndDestinationCannotBeSamePlace(mainPage.ErrorMessage);
        }

        public bool SelectNumberOfBabiesMoreThanNumberOfAdults()
        {
            PageHome mainPage = new PageHome(driver);
            mainPage.OpenPage();
            return mainPage.EnterTheNumberOfBabiesMoreThanNumberOfAdults(mainPage.AddBaby);
        }

    }
}