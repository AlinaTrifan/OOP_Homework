using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homeworks
{
    public class Mammal
    {
        private string name;

        public string Name { get; set; }
      
        public Mammal (string name)
        {
            this.Name = name;
            Console.WriteLine($"The mammal's name is: {this.Name}");
        }

        public void Move()
        {
            Console.WriteLine("This mammal moves");
        }

        public void Sleep()
        {
            Console.WriteLine("This mammal sleeps");
        }

        public void Eat()
        {
            Console.WriteLine("This mammal eats certain foods");
        }
    }
}
