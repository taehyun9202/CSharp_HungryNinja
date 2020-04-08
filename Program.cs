using System;
using System.Collections.Generic;
using RPG.Models;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // //human
            // Human Tyler = new Human("Tyler");
            // Human Bot = new Human("FightBot", 5, 5 ,5 ,20);
            // Console.WriteLine($"{Tyler.Name} is created!");
            // Tyler.ShowStats();
            // Bot.ShowStats();
            // Console.WriteLine($"{Bot.Name} is created!");
            // Tyler.Attack(Bot);
            // Tyler.ShowStats();
            // Bot.ShowStats();

            //Buffet
            Ninja Naruto = new Ninja("Naruto");
            Console.WriteLine($"{Naruto.Name} is created!");
            Buffet serveFood = new Buffet();
            Naruto.Eat(serveFood.Serve());
            Naruto.ShowCalories();
            Naruto.Eat(serveFood.Serve());
            Naruto.ShowCalories();
            Naruto.Eat(serveFood.Serve());
            Naruto.ShowCalories();
            Naruto.Eat(serveFood.Serve());
            Naruto.ShowCalories();
            
        }
    }
}
