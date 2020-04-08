using System;
using System.Collections.Generic;
namespace RPG.Models
{
    public class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food ("Shrimp Pasta", 800 , true, false),
                new Food ("Strawberry Smoothie", 400, false, true),
                new Food ("Coffee", 200, false, false),
                new Food ("Hamburger", 1000, false, false),
                new Food ("Orange Juice", 400, false, true),
                new Food ("Chili Nacho", 500, true, true),
            };
        }
        public Food Serve()
        {
            Random ranItem = new Random();
            Food item = Menu[ranItem.Next(Menu.Count)];
            // Console.WriteLine($"Selection: {item.Name}\n Calories: {item.Calories}\n Spicy:{item.IsSpicy}\n Sweet:{item.IsSweet}");
            return item;
        }
    }
}