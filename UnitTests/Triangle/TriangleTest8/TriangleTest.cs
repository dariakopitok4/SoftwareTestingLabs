using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Test
{
    [TestClass()]
    public class TriangleTest
    {
        [TestMethod()]
        public void Test_ab_c_66_13_returnfalse()
        {
            int a = 6;
            int b = 6;
            int c = 13;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.MyTriangle(a, b, c);

            Assert.AreEqual(r, status);
        }
    }
}