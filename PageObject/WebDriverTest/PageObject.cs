using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectPattern
{
    public class MainPage
    {
        private readonly IWebDriver driver;
        private readonly string url = "https://www.vueling.com/ru";

        public MainPage(IWebDriver browser)
        {
            this.driver = browser;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.ClassName, Using = "form-input origin")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.ClassName, Using = "form-input destination")]
        public IWebElement SearchBox2 { get; set; }

        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        public IWebElement GoButton { get; set; }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }

        public void Search(string textToType)
        {
            this.SearchBox.Clear();
            this.SearchBox.SendKeys(textToType);
            this.SearchBox2.Clear();
            this.SearchBox2.SendKeys(textToType);
            this.GoButton.Click();
        }
    }
}

