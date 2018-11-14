using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebDriverTest
{
    [TestFixture]
    public class WebDriverTest
    {
        const string url = "https://www.vueling.com/ru";
        const string departure = "form-input origin";
        const string destination = "form-input destination";
        const string buttonId = "btnSubmitHomeSearcher";
        const string valueCity = "Almeria";
        const string error = "popover popover--error";
        const string mess = "Вы должны выбрать один из вариантов";

        [Test]
        public void Test_enter_only_one_destination()
        {
            RemoteWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Navigate().GoToUrl(url);

            var txtFirstParm = driver.FindElementByClassName(departure);
            var txtSecondParm = driver.FindElementByClassName(destination);
            var but = driver.FindElementById(buttonId);

            txtFirstParm.Clear();
            txtFirstParm.SendKeys(valueCity);

            txtSecondParm.Clear();

            but.Click();

            var errorWindow = driver.FindElementByClassName(error);

            Assert.AreEqual(mess, errorWindow.Text);
        }
    }
}
