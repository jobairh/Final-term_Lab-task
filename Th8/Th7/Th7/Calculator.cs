using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th7
{
    class Calculator : MainCalculator, IBasicCalculator, IScientificCalculator
    {
        //public Calculator() { }
        //public Calculator(int x, int y) { }
        public void Own() { }
        public void division(int x, int y)
        {
            Console.WriteLine("division of x and y"+ x+y);
        }

        public void multiplication(int x, int y)
        {
            Console.WriteLine("multiplication of x and y");
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("sub of x and y");
        }

        public void Sum(int x, int y)
        {
            Console.WriteLine("Sum of x and y");
        }

        public void XtoY(int x, int y)
        {
            Console.WriteLine("XtoY of x and y");
        }
    }
}
