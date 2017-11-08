using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace RPGTextGame
{
    public enum TypesOfStats { HP, AttackDamage, MagicDamage, Armor, MagicResistence, Stamina, Luck, Intelligence, Experience, None, Invalid }

    class Core
    {

        static string command;

        #region Static Methods
        //An overload of Write might be useful for Speed Changing
        public static void Write(String text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                if (c == '\n')
                    Thread.Sleep(150);
                Thread.Sleep(30);
            }
            Console.Write("\n");
        }
        public static void Write(String text,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                if (c == '\n')
                    Thread.Sleep(150);
                Thread.Sleep(30);
            }
            Console.Write("\n");
        }

        public static String Read()
        {
            String playerInput = Console.ReadLine();
            return playerInput;
        }

        public static TypesOfStats StatEnumConverter(string statToCheck)
        {
            switch (statToCheck)
            {
                case "AttackDamage":
                    return TypesOfStats.AttackDamage;
                case "HP":
                    return TypesOfStats.HP;
                case "MagicResistence":
                    return TypesOfStats.MagicResistence;
                case "MagicDamage":
                    return TypesOfStats.MagicDamage;
                case "Armor":
                    return TypesOfStats.Armor;
                case "Stamina":
                    return TypesOfStats.Stamina;
                case "Luck":
                    return TypesOfStats.Luck;
                case "Intelligence":
                    return TypesOfStats.Intelligence;
                case "Experience":
                    return TypesOfStats.Experience;
                case "None":
                    return TypesOfStats.None;
                default:
                    Console.WriteLine("You didn't choose a valid Stat");
                    return TypesOfStats.Invalid;

            }
        }

    #endregion

        static void Main(string[] args)
        {
            CharacterHero hero = new CharacterHero("Anon", 500, 100, 50, 10, 25, 5, 1, 5, "Your clothes are filthy, and there's cuts and blood all over your body", 0, ConsoleColor.Cyan);
            //CharacterHero hero = new CharacterHero("Diogo", 900, 100, 50, 10, 30, 35, 5, 10, "Wubba Lubba Dub Dub ayy lmao", 999);
            UsableItem HealthPotion = new UsableItem("A Health Potion", "You feel vitalized", TypesOfStats.HP, 100);

            EquipableItem HermesShoes = new EquipableItem("Hermes Shoes", "Fast as hell boys", TypesOfStats.Luck, EquipableItem.TypeOfEquip.Boots, 30);

            Woods_1 explore = new Woods_1(hero);
            explore.Woodsini();

            OpeningNarrative narrative = new OpeningNarrative(hero);
            narrative.Start();
            Console.Clear();
            narrative.Chapter1();

            while (!Console.KeyAvailable)
            {
                
                command = Read().ToLower();
                if (command == "show bag")
                    hero.ShowBag();
                if (command == "look self")
                    hero.LookSelf();
                if (command == "look item")
                    hero.LookItem(HealthPotion);
                if (command == "use item")
                    hero.UseItem(HealthPotion);

                Thread.Sleep(3);
            }
        }

    }
}
