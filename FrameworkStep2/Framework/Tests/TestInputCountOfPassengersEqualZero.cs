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
        private const string WARNING_CHILD = "*Если на момент совершения полета несовершеннолетний не достигнет указанного возраста, он не будет допущен к посадке на борт самолета.";

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
        public void UnableEnterTheDateRetroactively()
        {
            steps.SelectDateRetroactively();
            Assert.AreEqual(true, steps.SelectDateRetroactively());
        }

        [Test]
        public void UnableSelectReturnDateOneYearAfterDeparture()
        {
            steps.SelectReturnDateOneYearAfterDeparture();
            Assert.AreEqual(false, steps.SelectReturnDateOneYearAfterDeparture());
        }

        [Test]
        public void UnableSelectDepartureDateWithoutDestinationDate()
        {
            steps.SelectDepartureDateWithoutDestinationDate();
            Assert.AreEqual(false, steps.SelectDepartureDateWithoutDestinationDate());
        }

        [Test]
        public void UnableSelectOnlyOneAirport()
        {
            steps.SelectOnlyOneAirport();
            Assert.AreEqual(ERROR_MESSAGE_CITY, steps.SelectOnlyOneAirport());
        }

        [Test]
        public void UnableSelectChildWithoutAdult()
        {
            steps.SelectChildWithoutAdult();
            Assert.AreEqual(WARNING_CHILD, steps.SelectChildWithoutAdult());
        }

        [Test]
        public void EnableSelectFlightParametrs()
        {
            steps.SelectFlightParametrs();
            Assert.AreEqual(ERROR_MESSAGE, steps.SelectFlightParametrs());
        }

        [Test]
        public void UnableSelectBabyWithoutAdultAsPassenger()
        {
            steps.SelectBabyWithoutAdultAsPassenger();
            Assert.AreEqual(false, steps.SelectBabyWithoutAdultAsPassenger());
        }    

        [Test]
        public void UnableSelectTwentyFivePassengers()
        {
            steps.SelectTwentyFivePassengers();
            Assert.AreEqual(true, steps.SelectTwentyFivePassengers());
        }

        [Test]
        public void UnableSelectAirportDepartureAndDestinationCannotBeSamePlace()
        {
            steps.SelectAirportDepartureAndDestinationCannotBeSamePlace();
            Assert.AreEqual(ERROR_MESSAGE_CITY, steps.SelectAirportDepartureAndDestinationCannotBeSamePlace());
        }

        [Test]
        public void UnableSelectNumberOfBabiesMoreThanNumberOfAdults()
        {
            steps.SelectNumberOfBabiesMoreThanNumberOfAdults();
            Assert.AreEqual(false, steps.SelectNumberOfBabiesMoreThanNumberOfAdults());
        }
    }
}