using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homeworks
{
    public class Allergies
    {
        private readonly string name;
        public string Name { get { return this.name; } }
        private readonly Allergens allergen;
        public Allergens Allergens { get { return this.allergen; } }
        
        public void AllergenType(int score)
        {
                int allergenscore = score;
                StringBuilder sb = new StringBuilder();
                while (allergenscore >= 1)
                {
                    int keepNumber = 0;
                    int keepAllergenScore = allergenscore;
                    foreach (int number in Allergens.GetValues(typeof(Allergens)))
                    {//to find out the highest allerngen number your score can have it
                        if (keepAllergenScore > 0)
                        {
                            keepAllergenScore -= number;
                            keepNumber = number;
                        }
                    }
                    sb.Append(Allergens.GetName(typeof(Allergens), keepNumber) + " ");
                    allergenscore -= keepNumber;
                }
                Console.WriteLine($"{this.name} has allergies and is allergic to: {sb.ToString()} ");
        }
    
        public Allergies(string name, int score1)
        {
            this.name = name;
            allergen = (Allergens)score1;

            if (score1 > 0 && score1 < 256)
            {
                AllergenType(score1);
            }
            else if (score1 > 256)
            {
                while (score1 > 256)
                {
                    score1 = score1 - 256;
                }
                AllergenType(score1);
            }
            else
            {
                Console.WriteLine($"{this.name} has no allergies");
            }
        }
    }
    
    public enum Allergens
    {
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128
    };
}
