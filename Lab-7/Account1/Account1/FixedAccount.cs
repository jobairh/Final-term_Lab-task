using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class FixedAccount :  SavingAccount
    {
        public int CreateYear { get; set; }

        public int TenureYear { get; set; }

        public FixedAccount() { }

        public FixedAccount(string accno,string accname,double balance, int createyear,int
            tenureyear) : base(accno,accname,balance) 
        {
            this.CreateYear = createyear;
            this.TenureYear = tenureyear;
        }
        public override void Withdraw(double amount)
        {
            string currentYear = DateTime.Now.Year.ToString();
            int cyear = Int32.Parse(currentYear);
            if((cyear - CreateYear) >= TenureYear)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("your account is not matured enough");
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account opening year: " + CreateYear);
            Console.WriteLine("Account tenure year: " + TenureYear);
        }

    }
}
