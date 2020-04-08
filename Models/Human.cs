using System;
namespace RPG.Models
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int HP;
        
        public int Health
        {
            get
            {
                return HP;
            }
        }
        
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            HP = 100;
        }
        public Human(string name, int Str, int Int, int Dex, int Health)
        {
            Name = name;
            Strength = Str;
            Intelligence = Int;
            Dexterity = Dex;
            HP = Health;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\n Strength: {Strength}\n Intelligence: {Intelligence}\n Dexterity: {Dexterity}\n HP: {HP}");
        }
        public int Attack(Human target)
        {   
            if(target is Human)
            {
                int dmg = 5 * Strength;
                target.HP -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name}!");
                return target.HP;
            }
            else
            {
                throw new Exception ("You can't attack");
            }
        }
    }
}