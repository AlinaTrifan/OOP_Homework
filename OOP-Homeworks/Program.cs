using System;
using System.Collections.Generic;

namespace OOP_Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rabbit OOP
            Rabbit rabbit = new Rabbit ("Pufulet", EyeColor.Black, FurColor.Brown, Gender.Female, 2017, 10, 10);
            rabbit.RabbitAge();
            rabbit.Sleep();
            rabbit.Move();
            rabbit.Eat();

            //Product OOP
            Product product = new Product("Alabala", "Albalact", 10.15, 2018, 10, 29, ProductCategorie.Bread);

            //BankAccount OOP
            try
            {
                BankAccount bankAccount = new BankAccount("Alina Trifan", 20);
                Console.WriteLine($"Account {bankAccount.Number} was created for {bankAccount.Owner} with the sum {bankAccount.Balance}");
                bankAccount.MakeWithdrawal(10, DateTime.Now);
                Console.WriteLine($"After the withdrawal the bank account {bankAccount.Number} has {bankAccount.Balance} ");
                bankAccount.MakeDeposit(100, DateTime.Now);
                Console.WriteLine($"After the deposit the bank account {bankAccount.Number} has {bankAccount.Balance} ");
                bankAccount.MakeDeposit(100, DateTime.Now);
                Console.WriteLine($"After the deposit the bank account {bankAccount.Number} has {bankAccount.Balance} ");
                bankAccount.CloseAccount();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
           

            //OOP allergies
            Allergies allergies = new Allergies("Tom", 1034);
        }
    }
}
