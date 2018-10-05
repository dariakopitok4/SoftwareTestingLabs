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
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    return false;
                }

                return true;
            }

            else { Console.WriteLine("This triangle cannot be built"); return false; }

        }
        static void Main(string[] args)
        {
        }
    }
}