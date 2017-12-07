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

        static List<string> commandList = new List<string> { "walk","hike","stroll","march","stride","step",
            "run","dart","dash","rush","sprint","escape","spurt","flight","jog",
            "talk","chat","communicate","say","speak","tell","articulate","chatter","converse","utter","voice","pronounce","verbalize",
            "sell",
            "buy","get","obtain","purchase","take","acquire",
            "look","glance","notice","see","stare","study","watch","admire","behold","beware","contemplate","focus","gaze","inspect","observe","scan","survey",
            "use","consume","apply","spend","wield","ply","expend",
            "fight","attack","battle","challenge","clash","meet","assault","bicker","brawl","contend","dispute","duel","feud","joust","quarrel","skirmish","spar","war","wrestle","tussle","wrangle",
            "explore","delve into","probe","scout","travel","traverse","reconnoitre","inspect",
            "give","award","deliver","donate","grant","hand over","hand out","present","hand over","provide","cede","entrust","gift","lease","relinquish"
        };

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
        public static void Write(String text, ConsoleColor color)
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
        public static void checkUserInput(string input)
        {
            if (!isInputValidCommand(input))
                Core.Write("Was that a typo?");
            else
            {
                
            }
            

        }

        public static bool isInputValidCommand(string input)
        {
            foreach (string i in commandList)
                if (i.Equals(input.ToLower()))
                    return true;
            return false;
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
            UsableItem HealthPotion = new UsableItem("A Health Potion", "You feel vitalized", TypesOfStats.HP, 100);

            EquipableItem HermesShoes = new EquipableItem("Hermes Shoes", "Fast as hell boys", TypesOfStats.Luck, EquipableItem.TypeOfEquip.Boots, 30);

            //Woods_1 explore = new Woods_1(hero);
            //explore.Woodsini();

            OpeningNarrative narrative = new OpeningNarrative(hero);
            Console.WriteLine("Debug opening narrative complete\n--------------------------------------------------------------------------------------------------\n");
            Console.Read();
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
