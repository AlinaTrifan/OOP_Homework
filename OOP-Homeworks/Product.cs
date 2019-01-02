using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homeworks
{
    public class Product
    {
        private readonly string name;
        private readonly double weight;
        private readonly string producer;
        private readonly DateTime productionDate;
        private readonly ProductCategorie productCategorie;
        
        public string Name { get { return this.name; } }

        public double Weight { get { return this.weight; } }

        public string Producer { get { return this.producer; } }

        public DateTime ProductionDate { get { return this.productionDate; } }

        public ProductCategorie ProductCategorie { get { return this.productCategorie; } }
        
        public Product (string name, string producer, double weight, int year, int month, int day, ProductCategorie productCategorie)
        {
            this.name = name;
            Console.WriteLine($"The product's name is : {this.name}");
            this.producer = producer;
            Console.WriteLine($"This product's producer is: {this.producer}");
            this.weight = weight;
            Console.WriteLine($"This product's weight is {this.weight}");
            this.productionDate = new DateTime(year, month, day);
            Console.WriteLine($"This product's production date is {this.productionDate}");
            this.productCategorie = productCategorie;
            Console.WriteLine($"This product is a {this.productCategorie}");
            Console.WriteLine($"This product's expiration date is: {ExpirationDate(this.productCategorie)}");
        }

        public DateTime ExpirationDate(ProductCategorie product)
        {
            if (product == ProductCategorie.Bevarages)
            {
                return this.productionDate.AddYears(3);
            }
            else if (product == ProductCategorie.Dairy)
            {
                return this.productionDate.AddDays(7);
            }
            else if (product == ProductCategorie.Fruit)
            {
                return this.productionDate.AddDays(2);
            }
            else 
            {
                return this.productionDate.AddDays(4);
            }
        }
       
    }
    public enum ProductCategorie { Dairy, Fruit, Bevarages, Bread }
}
