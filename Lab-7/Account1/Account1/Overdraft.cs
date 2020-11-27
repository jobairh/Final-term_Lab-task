using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class Overdraft : SavingAccount
    {
        //int overdraftLimit = 1000;
        public Overdraft() { }

        public Overdraft(string accno, string accname, double balance) : base(accno,
            accname, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            
            
                if (amount < Balance)
                {
                
                Balance -= amount;
               // Balance += overdraftLimit;
            }
                 
                //else if (overdraftLimit == 0)
                //{
                //    Console.WriteLine("overdraft limit is finish");
                //}
                else
                {
                    Console.WriteLine("insufficient balance");
                }

            

        }
    }
}
