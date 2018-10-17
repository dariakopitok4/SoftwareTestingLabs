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
        public void Test_abc_000_returnfalse()
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
        public void Test_b_minus9_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(5, -9, 15));
        }

        [Test]
        public void Test_c_minus17_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(5, 9, -17));
        }

        [Test]
        public void Test_abc_minus5minus9minus15_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(-5, -9, -15));
        }

        [Test]
        public void Test_abc_minus5_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(-5, 9, 15));
        }

        [Test]
        public void Test_ab_c_66_13_returnfalse()
        {
            Assert.AreEqual(false, t.Triangle(6, 6, 13));
        }

        [Test]
        public void Test_abc_662_returnfalse()
        {
            Assert.AreEqual(true, t.Triangle(6, 6, 2));
        }
    }
}
