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
        public void Test_c_0_returnfalse()
        {
            int a = 5;
            int b = 3;
            int c = 0;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.MyTriangle(a, b, c);

            Assert.AreEqual(r, status);
        }
    }
}