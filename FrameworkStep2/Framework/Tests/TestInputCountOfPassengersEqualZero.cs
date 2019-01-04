using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Framework
{
    [TestFixture]
    class TestInputCountOfPassengersEqualZero
    {
        private Steps steps = new Framework.Steps();
        private const string DATE_RETURN = "10.01.2020";
        private const string DATE_DEPARTURE = "10.01.2019";
        private const string ERROR_MESSAGE = "Вы должны заполнить это поле";
        private const string ERROR_MESSAGE_CITY = "Вы должны выбрать один из вариантов";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void UnableChoosePastDayOfDeparture()
        {
            steps.SelectPage();
            Assert.AreEqual(DATE_DEPARTURE, steps.UnableChoosePastDate());
        }

        [Test]
        public void UnableSelectReturnDateAfterOneYear()
        {
            steps.SelectPage();
            Assert.AreEqual(DATE_RETURN, steps.UnableChooseReturnDateAfterOneYear());
        }

        [Test]
        public void UnableSelectDepartureDateWithoutReturnDate1()
        {
            steps.SelectPage();
            Assert.IsNull(steps.UnableChoosePastDate());
        }

        [Test]
        public void CannotEnterOnlyOneDestination()
        {
            steps.SelectPage();
            Assert.AreEqual(ERROR_MESSAGE_CITY, steps.UnableChooseEqualAirportOfDepartureAndReturn());
        }

        [Test]
        public void UnableChooseYouthPersonLessThenTwelve()
        {
            steps.SelectPage();
            Assert.IsNotNull(steps.UnableChooseYouthPersonLessThenTwelveYear());
        }

        [Test]
        public void CountOfPassengersEqualZero()
        {
            steps.SelectNoOnePerson();
            Assert.AreEqual(ERROR_MESSAGE, steps.ErrorMessage());
        }

        [Test]
        public void UnableChooseBabeWithoutAdult()
        {
            steps.SelectPage();
            Assert.IsNull(steps.CannotChooseBabeWithoutAdult());
        }    

        [Test]
        public void UnableChooseCountOfPessangerMoreThenTwentySixPeople()
        {
            steps.SelectPage();
            Assert.IsNotNull(steps.UnableChooseCountOfPessangerMoreThenTen());
        }

        [Test]
        public void UnableChooseEqualDepartureAndReturnAirport()
        {
            steps.SelectPage();
            Assert.IsNull(steps.UnableChooseEqualAirportOfDepartureAndReturn());
        }
    }
}