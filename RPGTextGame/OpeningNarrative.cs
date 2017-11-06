using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPGTextGame
{
    class OpeningNarrative
    {

        public OpeningNarrative(CharacterHero hero)
        {
            hero = this.hero;
        }

        CharacterHero hero = new CharacterHero("Anon", 500, 100, 50, 10, 25, 5, 1, 5, "Your clothes are filthy, and there's cuts and blood all over your body", 0);

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

        public static void WriteSlow(String text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                if (c == '\n')
                    Thread.Sleep(500);
                Thread.Sleep(85);
            }
            Console.Write("\n");
        }
        #endregion

        public void Start()
        {
            String name;
            String input;
            Thread.Sleep(500);
            Write("...");
            Thread.Sleep(1000);
            Write("...");
            Thread.Sleep(1000);
            Write("'Hello?!'");
            Thread.Sleep(1000);
            Write("'Is someone there?!'");
            Thread.Sleep(1000);
            Write("You hear footsteps coming towards you.");
            Thread.Sleep(1000);
            Write("'What the... How...'");
            Thread.Sleep(500);
            Write("'Are you alive? Do you have a name?'");
            Thread.Sleep(500);
            Write("Your name: ");
            hero.name = Console.ReadLine();
            Write("'" + hero.name + ", is it?" + "");
            Write("Yes / No");
            input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                Write("Well, " + hero.name + ", let's get you the fuck out of here.");
                Thread.Sleep(500);
            }
            else
            {
                Write("Your name: ");
                hero.name = Console.ReadLine();
                Write("Well, " + hero.name + ", let's get you the fuck out of here.");
                Thread.Sleep(500);
            }
            //Cstring Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, string Description, int Experience

            Write("You see a hand reaching out to you.");
            Thread.Sleep(500);
            WriteSlow("Suddenly, you start to black out...");
            Thread.Sleep(1500);
        }

        public void Chapter1()
        {
            Write("Rain is falling on your face.");
            Thread.Sleep(1000);
            Write("You can't remember the last time you felt rain, or saw the sky for that matter.");
            Thread.Sleep(1000);
            Write("Now that you think about it, you can't remember much at all.");
            Thread.Sleep(1000);
            Write("Someone is sitting next to you. They haven't noticed you've woken up yet.");
            Thread.Sleep(1000);
            Write("You notice that this person has red hair. You've never seen hair like this.");
            Thread.Sleep(1000);
            Write("Red, almost like it was covered in blood. It sends a chill down your spine.");
            Thread.Sleep(1000);
            WriteSlow("'H-hello?...'");
            Thread.Sleep(1000);
            Write("You realize this person is talking to you.");
            Thread.Sleep(1000);
            Write("DURR HURR PREPARE FOR BATTLE!!!!!!");
            EnemyCharacter enemy = new EnemyCharacter("Ratatat", 500, 100, 50, 10, 25, 5, 1, 5, "Your clothes are filthy, and there's cuts and blood all over your body", 0);
            Battle openingBattle = new Battle(hero, enemy);
            openingBattle.BattleTurnBased();

        }
    }
}
