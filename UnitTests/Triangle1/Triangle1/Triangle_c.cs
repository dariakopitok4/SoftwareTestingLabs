using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle1
{
    class Triangle_c
    {
        public bool Triangle(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                {
                    return false;
                }

                return true;
            }

        static void Main(string[] args)
        {
        }
    }
}