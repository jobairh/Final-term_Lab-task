using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th7
{
    abstract class MainCalculator
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public MainCalculator() { }
        public MainCalculator(int x, int y) 
        {
            X = x;
            Y = y;
        }
        public void ShowInfo()
        {
            Console.WriteLine("value of x: " + X);
            Console.WriteLine("value of y: " + Y);
        }
    }
}
