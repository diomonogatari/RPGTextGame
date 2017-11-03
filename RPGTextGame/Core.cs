using System;
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
        static String intro = "Greetings summoner \nprepare to die";
        static String command;
        static String commandReturn;



        #region Static Methods
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

        private static String Read()
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
            CharacterHero hero = new CharacterHero("Diogo", 900,100,50,10,30,35,5,10,"Wubba Lubba Dub Dub ayy lmao", 999);

            while (!Console.KeyAvailable)
            {
                command = Read();
                if (command == "show bag".ToLower())
                    hero.ShowBag();
                else
                    Write(command/*commandReturn will replace command after interpertation is implemented*/);

                Thread.Sleep(3);
            }
        }

    }
}
