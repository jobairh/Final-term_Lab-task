using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    interface IBasicCalculator
    {
        void sum(int x, int y);

        void sub(int x, int y);

        void multiplication(int x, int y);

        void division(int x, int y);
    }
}
