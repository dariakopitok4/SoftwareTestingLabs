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
        private IWebElement destinationBox;
        [FindsBy(How = How.ClassName, Using = "form-input destination")]
        private IWebElement departureBox;
        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        private IWebElement findButton;
        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        private IWebElement errorMess;

        public IWebElement DestinationBox { get => destinationBox; }
        public IWebElement DepartureBox { get => departureBox; }
        public IWebElement FindButton { get => findButton; }
        public IWebElement ErrorMess { get => errorMess; }
    }
}
