using System;
//using System.Collections.Generic; 
//using System.Linq;
//using System.Text;
//using System.Threadings.Text;

 abstract class BankAccount

    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }


        public BankAccount()
        { 
          Balance = 1000;
        }

         public BankAccount(double balance)
        {
           Balance = balance;
        }

        public double Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("Current Balance: " + Balance);

            return Balance;
        }
      
        public virtual double Withdraw(double amount)
        {
            if(Balance > amount)
            {
              Balance = Balance - amount;

               Console.WriteLine("Current Balance: " + Balance);
            }
            else{
            Console.WriteLine("error.");
            }

            return Balance;
           }

        public abstract void CalculateInterest();
        
  }
