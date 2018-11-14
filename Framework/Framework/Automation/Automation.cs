using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Framework
{
    [TestFixture]
    class Automation
    {
        private Steps steps = new Framework.Steps();
        private const string errorMess = "Вы должны заполнить это поле";
        
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
        public void CountOfPassengersEqualZero()
        {
            steps.SelectNoOnePerson();
            Assert.AreEqual(errorMess, steps.ErrorMessage());
        }
    }
}
