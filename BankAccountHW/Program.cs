using BankAccountHW;

Console.WriteLine(BankAccountBase.BankName+" HOŞ GELDİNİZ!");
//Nesneler
CheckingAccount cust1 = new CheckingAccount("TR0123456", "Hafsa", "Eker");
CheckingAccount cust2 = new CheckingAccount("TR0789256", "Celal", "Eker");

InvestmentAccount cust3 = new InvestmentAccount("TR0752528", "Hamza", "Eker");
InvestmentAccount cust4 = new InvestmentAccount("TR02528885", "Ömer", "Eker");
//Para Yatırma İşlemleri
cust1.DepositMoney(95725);
cust2.DepositMoney(80000);
cust3.DepositMoney(77529);
cust4.DepositMoney(52727);
cust2.DepositMoney(-500);//-değer girişimi engeli


//Para Çekme İşlemleri
cust1.WithdrawMoney(2000);
cust2.WithdrawMoney(548446); //fazla çekme girişimi
cust3.WithdrawMoney(1258);
cust4.WithdrawMoney(62588); //fazla çekme girişimi
//Vadesiz Hesap Limiti 
cust1.AdditionalAccountLimit = 2000;
cust2.AdditionalAccountLimit = 3598;

//Komisyon Oranları
cust3.CommissionRate = 28;
cust4.CommissionRate = 72;

Console.WriteLine(BankAccountBase.BankInfo());