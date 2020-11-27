using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    abstract class AccountDetails
    {
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public double Balance { get; set; }

        public AccountDetails() { }

        public AccountDetails(string accno, string accname, double balance) 
        {
            this.AccNo = accno;
            this.AccName = accname;
            this.Balance = balance;
        }
        public void deposit(double amount)
        {
            Balance += amount;
        }
        public abstract void Withdraw(double amount);
        /*{
            if(amount < Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }*/
        public virtual void ShowInfo()
        {
            Console.WriteLine("Account no: " + AccNo);
            Console.WriteLine("Account name: " + AccName);
            Console.WriteLine("Account balance: " + Balance);
        }

    }
}
