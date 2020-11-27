using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountDetails a1 = new SavingAccount("1002","Tanvir",12000.00);
            AccountDetails a2 = new FixedAccount("2200","Jobair",20000.00,2005,10);
            AccountDetails a3 = new SpecialSavingAccount("3003","Ashik",30000.00);
            AccountDetails a4 = new Overdraft("4001","Payel",20000.00);
            a1.ShowInfo();
            Console.WriteLine("---------------");
            a2.ShowInfo();
            Console.WriteLine("---------------");
            a3.ShowInfo(); 
            Console.WriteLine("---------------");
            a4.ShowInfo();
            Console.WriteLine("---------------");
            a1.Withdraw(11000);
            a1.ShowInfo();
            Console.WriteLine("---------------");
            a2.Withdraw(20000);
            a2.ShowInfo();
            Console.WriteLine("---------------");
            a3.Withdraw(28000);
            a3.ShowInfo();
            Console.WriteLine("---------------");
            a4.Withdraw(20000);
            a4.ShowInfo();
            Console.WriteLine("---------------");
            a4.Withdraw(1000);
            a4.ShowInfo();
            Console.WriteLine("---------------");
            a4.Withdraw(5000);
            a4.ShowInfo();
        }
    }
}
