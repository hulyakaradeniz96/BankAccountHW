using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountHW
{
    internal class CheckingAccount : BankAccountBase
    {
        public CheckingAccount(string iBANNo, string name, string surname) : base(iBANNo, name, surname)
        {
        }
        private decimal _accountLimit;

        public decimal AdditionalAccountLimit
        {
            get { return _accountLimit; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Limit negatif olamaz.");
                }
                else
                {
                    _accountLimit = value;
                }
            }
        }


    }
}
