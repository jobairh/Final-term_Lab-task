using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class SavingAccount : AccountDetails
    {
        public SavingAccount() { }

        public SavingAccount(string accno, string accname, double balance) : base(accno,
            accname,balance)  
        {

        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 500)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
    }
}
