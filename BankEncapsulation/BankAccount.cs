using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        //Feilds
        private double _balance = 0;

        //Methods
        public void Deposit(double depositAmmount)
        {
            _balance += depositAmmount;
        }

        public double GetBalance() 
        { 
            return _balance;
        }
    }
}
