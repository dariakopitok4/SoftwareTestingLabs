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
        public void Test_abc_000_returnfalse()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            bool r = false;

            Triangle_c t = new Triangle_c();
            bool status = t.MyTriangle(a, b, c);

            Assert.AreEqual(r, status);
        }
    }
}