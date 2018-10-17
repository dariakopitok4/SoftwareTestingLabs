using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace WebDriverTests

{
    [TestClass]
    public class WebDriverTest
    {
        [TestMethod]
        public void Test_enter_only_one_destination()
        {
            
            RemoteWebDriver Driver = new ChromeDriver();
           var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30)); 
            Driver.Navigate().GoToUrl( @"https://www.vueling.com/ru");
            string classname = @"form - input origin";
            wait.Until(ExpectedConditions.ElementExists(By.ClassName(classname)));
            var txtFirstParm = Driver.FindElementByClassName(classname);
            var txtSecondParm = Driver.FindElementByClassName(@"form-input destination");
            var but = Driver.FindElementById("btnSubmitHomeSearcher");
            txtFirstParm.Clear();
            txtFirstParm.SendKeys("Almeria");

            txtSecondParm.Clear();

            but.Click();
        }
    }
}
