using System;
using System.Reflection.Emit;

namespace Task_Bank
{
    abstract class Bank
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Code16 { get; set; }
        public string CVV { get; set; }
        public decimal Balance { get; set; }

        public Bank(string name, string surname, string code16, string cvv, decimal balance)
        {
            Name = name;
            Surname = surname;
            Code16 = code16;
            CVV = cvv;
            Balance = balance;

        }


        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Code16 + " " + CVV + " " + Balance;
        }

    }
    class Unibank : Bank 
    {
       
        public Unibank(string name, string surname, string code16, string cvv, decimal balance) : base(name, surname, code16, cvv, balance) { }
        

        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }
        public override  void Withdraw(decimal amount)
        {
           
            if (amount > 0)
            {
                Balance = Balance - amount - ((amount * 1.5m) / 100);

            }
            if (amount > Balance && Balance < 0)
            {
                Balance = 0;
            }
        }
      

    }

    class AccessBank : Bank
    {
        
        public AccessBank(string name, string surname, string code16, string cvv, decimal balance) : base(name, surname, code16, cvv, balance) { }


        public override void Deposit(decimal amount)
        {
            Balance +=  amount - (( amount*0.3m)/100);
        }
        public override void Withdraw(decimal amount)
        {
            if(amount > 0)
            {
                Balance -= amount - ((amount * 1.6m) / 100);
            }
            if(amount > Balance && Balance < 0)
            {
                Balance = 0;
            }
        }

    }

    class PashaBank : Bank
    {
        
        public PashaBank(string name, string surname, string code16, string cvv, decimal  balance) : base(name, surname, code16, cvv, balance) { }

        public override void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                Balance += amount - ((amount * 0.6m) / 100);
            }
            
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                Balance -= amount - ((amount * 1.1m) / 100);
            }
            if (amount > Balance && Balance <0)
            {
                Balance = 0;
            }
        }

    }
    
    class LeoBank : Bank
    {

        public LeoBank(string name, string surname, string code16, string cvv, decimal balance) : base(name, surname, code16, cvv, balance) { }

        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            if(amount > Balance && Balance < 0)
            {
                Balance = 0;
            }
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
            }
            if(amount > Balance && Balance<0)
            {
               Balance = 0;

            }
            
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Unibank uni = new("Vugar", "Jabrailzade", "4546414252536253", "214",400m);
            uni.Deposit(100m);
            uni.Withdraw(100m);
            Console.WriteLine(uni);

            AccessBank acc = new("Vugar", "Jabrailzade", "4546414252536253", "325",500m);  
            acc.Deposit(700m);
            acc.Withdraw(100m);
            Console.WriteLine(acc);

            PashaBank pasha = new("Vugar", "Jabrailzade", "4163897451231023", "740", 1000m);
            pasha.Deposit(100m);
            pasha.Withdraw(100m);
            Console.WriteLine(pasha);


            LeoBank leo = new("Vugar", "Jabrailzade", "4512697854123256", "569", 2000m);
            leo.Deposit(100m);
            leo.Withdraw(400m);
            Console.WriteLine(leo);







        }
            

        
    }
}