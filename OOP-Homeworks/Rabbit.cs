using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homeworks
{
    public class Rabbit : Mammal
    {
        private readonly EyeColor eyeColor;
        private readonly FurColor furColor;
        private readonly Gender gender;
        private readonly DateTime dateOfBirth;

        public Gender Gender { get { return this.gender; } }

        public EyeColor EyeColor{ get { return this.eyeColor; } }

        public FurColor FurColor { get { return this.furColor; } }

        public DateTime DateOfBirth{ get { return this.dateOfBirth; } }

        public Rabbit( string name, EyeColor eyeColor, FurColor furColor, Gender gender, int year, int month, int day) : base (name)
        {
            this.Name = name;
            this.eyeColor = eyeColor;
            Console.WriteLine($"The rabbit's eye color is {this.eyeColor}");
            this.furColor = furColor;
            Console.WriteLine($"The rabbit's fur color is {this.furColor}");
            this.gender = gender;
            Console.WriteLine($"The rabbit's gender is {this.gender}");
            dateOfBirth = new DateTime(year, month, day);
            
        }

        public void RabbitAge()
        {
            int rabbitAge = (int)DateTime.Now.Year - (int)dateOfBirth.Year;
            if (rabbitAge == 0)
            {
                int rabbitMonths = (int)DateTime.Now.Month - (int)dateOfBirth.Month;
                if (rabbitMonths == 0)
                {
                    int rabbitDays = (int)DateTime.Now.Day - (int)dateOfBirth.Day;
                    if (rabbitDays == 0)
                    {
                        Console.WriteLine("The rabbit was born today");
                    }
                    else
                    {
                        Console.WriteLine($"The rabbit's age is {rabbitDays} days");
                    }
                }
                else
                {
                    Console.WriteLine($"The rabbit's age is: {rabbitMonths} months");
                }
            }
            else
            {
                Console.WriteLine($"The rabbit's age is: {rabbitAge} year");
            }
        }
    }

    public enum EyeColor { Blue, Red, Black }

    public enum FurColor { White, Brown, Black, Grey}

    public enum Gender { Female, Male }
}
