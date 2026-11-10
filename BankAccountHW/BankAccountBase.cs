using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountHW
{
    internal class BankAccountBase //parent/base class
    {
        public const string BankName= "BEYAZ BANK";
        public readonly string IBANNo;
        public DateTime CreatedDate { get; }
        public static int Count { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public decimal Balance { get; private set; }

        public BankAccountBase(string iBANNo, string name, string surname)
        {
            IBANNo = iBANNo;
            CreatedDate = DateTime.Now;
            Name = name;
            Surname = surname;
            Balance = 0;
            Count++;
            Console.WriteLine($"{IBANNo}: {Name} {Surname} ile kayıt oluşturuldu.\nBakiyeniz: 0 TL\n");
        }
 

        public void WithdrawMoney(decimal amount) //Para Çek
        {
            if (CheckAmount(amount))
            {
                if (CheckBalance(amount))
                {
                    Balance -= amount;
                    CurrentBalanceInfo();
                }
                else
                {
                    CustomerInfo();
                    Console.WriteLine($"Çekmek istediğiniz miktar({amount} TL) Mevcut Bakiyenizden ({Balance} TL) fazla.\nLütfen daha sonra tekrar deneyiniz. ");
                }
            }

        }

        public void DepositMoney(decimal amount) //Para Yatırma
        {
            if (CheckAmount(amount))
            {
                Balance += amount;
                CurrentBalanceInfo();
            }

        }
        public void CustomerInfo()
        {
            Console.WriteLine($"\n{IBANNo}: {Name} {Surname}");
        }
        public bool CheckAmount(decimal amount)
        {
            if (amount > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"\n{amount}: Tutar miktarı yanlış girildi.");
                return false;
            }
        }

        public void CurrentBalanceInfo()
        {
            CustomerInfo();
            Console.WriteLine($"Güncel Bakiyeniz: {Balance} TL");
        }

        public bool CheckBalance(decimal amount) //Bakiye Kontrol
        {
            if (amount > Balance)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string BankInfo()
        {
            return $"\nBanka Adı:{BankName}\n" +
                $"Hesap Sayısı: {Count}";
        }


    }
}
