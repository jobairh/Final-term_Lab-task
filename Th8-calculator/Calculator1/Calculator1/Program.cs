using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.multiplication(10,5);
            c.division(10, 5);
            c.sub(10, 5);
            c.sum(10, 5);
            c.XtoY(10, 5);
            
        }
    }
}
