using System;
using System.Collections.Generic;
namespace RPG.Models
{
    public class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy; 
        public bool IsSweet; 
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }

}