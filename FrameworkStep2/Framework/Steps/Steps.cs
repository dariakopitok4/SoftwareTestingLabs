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

        public void SelectPage()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.OpenPage();
            selectPage.SelectMoreThenOneBaby();
        }

        public void SelectNoOnePerson()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.OpenPage();
            selectPage.ChoiceFlightParametrs();
        }

        public string ErrorMessage()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.GetErrorMes();
        }

        public void ChooseYouthPersonLessThenTwelve()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.OpenPage();
            selectPage.IndependentFlightForChildrenUnderTwelveYearsOld();
        }

        public string UnableChooseYouthPersonLessThenTwelveYear()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.GetYearOfBirth();
        }

        public string CannotChooseBabeWithoutAdult()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.GetYearOfBirth();
        }

        public void ChoosePastDateOfReturn()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.SelectDateOfDepartureAndDateOfReturn();
        }

        public string UnableChoosePastDate()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.SelectRightDateOfReturn();
        }

        public string UnableChooseReturnDateAfterOneYear()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.SelectRightDateOfReturn();
        }

        public void ChoosePastDateOfReturnAndDeparure()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.SelectPastDateOfDepartureAndReturn();
        }
        s
        public string UnableChoosePastDateOfReturnAndDeparure()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.SelectRightDateOfReturnAndDeparture();
        }

        public void ChooseBigCountOfPessanger()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.ChooseNumberOfPassengers();
        }

        public string UnableChooseCountOfPessangerMoreThenTen()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.GetErrorAboutNumberOfPassengers();
        }

        public void ChooseEqualAirportOfDepartureAndReturn()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.SelectEqualAirportOfDepartureAndReturn("Минск", "Минск");
        }

        public string UnableChooseEqualAirportOfDepartureAndReturn()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.ErrorMessAboutNotEqualAirportOfDepartureAndReturn();
        }

        public void ChooseZeroCountOfPeople()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.ChooseZeroCountOfPassengers();
        }

        public string UnableChooseZeroCountOfPeople()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.GetErrorAboutZeroCountOfPassengers();
        }

        public void ChoosePersonWichNeedSpecialHelp()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.OpenPage();
            selectPage.ChoosePessangerWichNeedSpecialHelp();
        }

        public string CanChoosePersonWichNeedSpecialHelp()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.GetPessangerWichNeedSpecialHelp();
        }

        public void SelectPossibilityToTransferDataToThirdFace()
        {
            PageHome selectPage = new PageHome(driver);
            selectPage.OpenPage();
            selectPage.ChoosePessangerWichNeedSpecialHelp();
        }

        public string CanChoosePossibilityToTransferDataToThirdFace()
        {
            PageHome mainPage = new PageHome(driver);
            return mainPage.GetPessangerWichNeedSpecialHelp();
        }
    }
}