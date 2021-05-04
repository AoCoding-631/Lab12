using System;

class SavingsAccount : BankAccount
  {
    public SavingsAccount{

      public SavingsAccount : (double 0.5)
        {
           Balance = Balance + interest;  
        }

        public CheckingAccount(string BankAccount) : base("SavingsAccount",BankAccount)
        {            
            Deposit(2000);
            Withdraw(1000);
        }
        
        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("Savings amount");
        }
    }
  }