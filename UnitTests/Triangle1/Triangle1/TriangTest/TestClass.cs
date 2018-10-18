using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Triangle1
{
    [TestFixture]
    class TestClass
    {

        Triangle_c t = new Triangle_c();

        [Test]
        public void Test_c_0_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(3, 5, 0));
        }

        [Test]
        public void Test_abc_0_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(0, 0, 0));
        }

        [Test]
        public void Test_a_0_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(0, 5, 5));
        }

        [Test]
        public void Test_b_0_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(8, 0, 15));
        }

        [Test]
        public void Test_b_minus_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(5, -9, 15));
        }

        [Test]
        public void Test_c_minus_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(5, 9, -17));
        }

        [Test]
        public void Test_abc_minus_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(-5, -9, -15));
        }

        [Test]
        public void Test_a_minus_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(-5, 9, 15));
        }

        [Test]
        public void Test_с_more_than_ab_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(6, 6, 13));
        }

        [Test]
        public void Test_c_less_than_ab_returntrue()
        {
            Assert.AreEqual(true, t.Triangle(6, 6, 2));
        }
    }
}
