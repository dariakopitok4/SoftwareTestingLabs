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
        [TestCase]
        public void Test_c_0_returnfalse()
        {
            int a = 5;
            int b = 3;
            int c = 0;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status);
        }

        [TestCase]
        public void Test_abc_000_returnfalse()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status); }

        [TestCase]
        public void Test_a_0_returnfalse()
        {
            int a = 0;
            int b = 9;
            int c = 15;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status);
        }

        [TestCase]
        public void Test_b_0_returnfalse()
        {
            int a = 8;
            int b = 0;
            int c = 15;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status);
        }

        [TestCase]
        public void Test_b_minus9_returnfalse()
        {
            int a = 5;
            int b = -9;
            int c = 15;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status);
        }

        [TestCase]
        public void Test_c_minus17_returnfalse()
        {
            int a = 5;
            int b = 9;
            int c = -17;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status);
        }

        [TestCase]
        public void Test_abc_minus5minus9minus15_returnfalse()
        {
            int a = -5;
            int b = -9;
            int c = -15;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status);
        }

        [TestCase]
        public void Test_abc_minus5_returnfalse()
        {
            int a = -5;
            int b = 9;
            int c = 15;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status);
        }

        [TestCase]
        public void Test_ab_c_66_13_returnfalse()
        {
            int a = 6;
            int b = 6;
            int c = 13;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status);
        }

        [TestCase]
        public void Test_abc_662_returnfalse()
        {
            int a = 6;
            int b = 6;
            int c = 2;
            bool r = true;

            Triangle_c t = new Triangle_c();
            bool status = t.Triangle(a, b, c);

            Assert.AreEqual(r, status);
        }
    }
}
