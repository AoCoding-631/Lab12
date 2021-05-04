using System;

class CheckingAccount : BankAccount
    {
      
    
      public CheckingAccount() : (double 0.5)
        {
           Balance = Balance + interest;
        }

        public CheckingAccount(string BankAccount) : base("CheckingAccount",BankAccount)
        {            
          
            Deposit(2000);
            Withdraw(1000);
            
        }

        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("Checking amount");
        }
    }