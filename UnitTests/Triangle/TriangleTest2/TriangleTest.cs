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
        public void Test_a_0_returnfalse()
        {
            int a = 0;
            int b = 9;
            int c = 15;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.MyTriangle(a, b, c);

            Assert.AreEqual(r, status);
        }
    }
}