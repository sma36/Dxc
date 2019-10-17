using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class CalcArea
    {        
        public void area(int r)
        {
            Console.WriteLine("Area of Circle = "+(Math.PI*r*r));
        }
        public void area(int l,int b)
        {
            Console.WriteLine("Area of Rectangle = " + (l*b));
        }
        public void area(int l,int b,int h)
        {
            Console.WriteLine("Area of Cuboid = " + (l*b*h));
        }
    }
}
