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
            //BankAccount bankAccount = new BankAccount("Alina Trifan", 100);
            //Console.WriteLine($"Account {bankAccount.Number} was created for {bankAccount.Owner} with the sum {bankAccount.Balance}");
            //try
            //{
            //    bankAccount.Withdrawals(-1, DateTime.Now);
            //    Console.WriteLine($"After the widtdrawal the bank account {bankAccount.Number} has {bankAccount.Balance} ");
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{ 
                BankAccount bankAccount1 = new BankAccount("Alin Trifan", 100);
            //}
            catch (ArgumentException e1)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e1.Message);
            }
        }
    }
}
