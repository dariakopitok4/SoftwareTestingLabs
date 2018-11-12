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
namespace WebDriverT
{
    class FindElements
    {
        /// <summary>Строка для ввода текста поиска</summary>
        [FindsBy(How = How.ClassName, Using = "form-input origin")]
        public IWebElement destinationBox;
        [FindsBy(How = How.ClassName, Using = "form-input destination")]
        public IWebElement departureBox;
        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        public IWebElement findButton;
        [FindsBy(How = How.Id, Using = "btnSubmitHomeSearcher")]
        public IWebElement errorMess;
    }
}
