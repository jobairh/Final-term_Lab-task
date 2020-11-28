using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class Calculator : IBasicCalculator, IScientificCalculator
    {
        //public Calculator() { }
        //public Calculator(int x,int y)
        //{ 
        //}

        public void division(int x, int y)
        {
            int div = x / y;
            Console.WriteLine("division of x and y: " + div);
        }

        public void multiplication(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("multiplication of x and y: " + mul);
        }

        public void sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("subtraction of x and y: " + sub);
        }

        public void sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("summation of x and y: " + sum);
        }

        public void XtoY(int x, int y)
        {
            double XtoY = Math.Pow(x,y);
            Console.WriteLine("XtoY of x and y: " + XtoY);
        }
    }
}
