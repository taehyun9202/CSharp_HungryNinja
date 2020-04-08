using System;
using System.Collections.Generic;
namespace RPG.Models
{
    public class Ninja : Human
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja(string name) : base(name,5,5,5,20)
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool isFull
        {
            get{
                if(calorieIntake > 1200)
                {
                    return true;
                }
                else
                {   
                    
                    return false;
                }
            }
        }
        public void ShowCalories()
        {
            Console.WriteLine($"Name: {Name}\nCalories: {calorieIntake}");
        }
        public void Eat(Food item)
        {
            if(isFull == false)
            {
                FoodHistory.Add(item);
                calorieIntake += item.Calories;
                Console.WriteLine(FoodHistory);
                Console.WriteLine(calorieIntake);
                Console.WriteLine($"{Name} ate {item.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't eat any more");
            }
        }
    }
}
