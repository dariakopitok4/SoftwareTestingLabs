using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using NUnit.Framework;

namespace WebDriverTest
{
    [TestFixture]
    public class WebDriverTest
    {
        string firstParm = "form-input origin";
        string secondParm = "form-input destination";
        string buttonId = "btnSubmitHomeSearcher";
        string valueCity = "Almeria";
        string errorMess = "popover popover--error";


        [Test]
        public void Test_enter_only_one_destination()
        {
            RemoteWebDriver Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            Driver.Navigate().GoToUrl("https://www.vueling.com/ru");

            var txtFirstParm = Driver.FindElementByClassName(firstParm);
            var txtSecondParm = Driver.FindElementByClassName(secondParm);
            var but = Driver.FindElementById(buttonId);
            txtFirstParm.Clear();
            txtFirstParm.SendKeys(valueCity);

            txtSecondParm.Clear();

            but.Click();

            var error = Driver.FindElementByClassName(errorMess);

        }
    }
}
