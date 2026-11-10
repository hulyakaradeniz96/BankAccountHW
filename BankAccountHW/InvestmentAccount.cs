using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountHW
{
    internal class InvestmentAccount : BankAccountBase
    {
        public InvestmentAccount(string iBANNo, string name, string surname) : base(iBANNo, name, surname)
        {
        }

        private decimal _commissionRate;

        public decimal CommissionRate
        {
            get { return _commissionRate; }
            set { 
                if(!(value<100 && value > 0))
                {
                    Console.WriteLine("Oran yanlış girildi.");
                }
                else
                {
                    _commissionRate = value;
                }
            }
        }


    }
}
