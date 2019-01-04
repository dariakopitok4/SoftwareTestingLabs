using System;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace PageObjectLab
{
    class PageHome
    {
        [FindsBy(How = How.ClassName, Using = "form-input origin")]
        private IWebElement departureCity;
        [FindsBy(How = How.ClassName, Using = "form-input destination")]
        private IWebElement destinationCity;
        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        private IWebElement findButton;
        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        private IWebElement errorMessage;

        public IWebElement DestinationCity { get => destinationCity; }
        public IWebElement DepartureCity { get => departureCity; }
        public IWebElement FindButton { get => findButton; }
        public IWebElement ErrorMessage { get => errorMessage; }
    }
}
