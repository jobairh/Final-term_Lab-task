using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class SpecialSavingAccount : SavingAccount
    {
        public SpecialSavingAccount() { }

        public SpecialSavingAccount(string accno, string accname, double balance) : base(accno,
            accname, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if (amount<=Balance)
            {
                Balance -= 20;
                Balance -= amount;   
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
    }
}
