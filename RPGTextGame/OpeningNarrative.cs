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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("'Hello?!'");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("'Is someone there?!'");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Write("You hear footsteps coming towards you.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("'What the... How...'");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("'Are you alive? Fucks sake, WE HAVE TO GO!'");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
            Write("You see a hand reaching out to you.");
            Thread.Sleep(500);
            Write("Suddenly, you start to black out...");
            Thread.Sleep(1500);
        }

        public void Chapter1()
        {
            String input;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1500);
            Write("Rain is falling on your face.");
            Thread.Sleep(2500);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("'Oh, you're awake.'");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Write("You realize this person is talking to you.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("'You're lucky you made it out of there alive, you know?'");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Write("You're speechless. You finally get a glimpse of this person's face.");
            Thread.Sleep(1000);
            Write("She has strong features, some scars, yet her face is delicate.");
            Thread.Sleep(1000);
            Write("She is skinny. Surprisingly skinny.");
            Write("Yet, she has been sharpening a sword bigger than you.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("'You do remember how to talk, right?'");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Write("Yes / No");
            input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Write("'Knew it.'");
                Thread.Sleep(1000);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Write("'Yeah, right.'");
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Write("She stands up. She looks threatning on her feet.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("'Need a hand?'");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Write("Yes / No");
            input = Console.ReadLine();

            if (input.ToLower() == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Write("'Here you go.'");
                Thread.Sleep(1000);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Write("'Well, you're not going to stay sitting there. Come on.'");
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Write("She's stronger than she looks. She effortlessly helps you get up.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("I'm Viola. Vi for short.");
            Thread.Sleep(500);
            Write("Do you have a name?");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
            Write("That was a weird question. You hadn't given much thought to it.");
            Thread.Sleep(500);
            Write("You try to remember if you had a name...");
            Thread.Sleep(500);
            Write("You name is: ");
            hero.name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write("'" + hero.name + ", is it?" + "");
            Console.ForegroundColor = ConsoleColor.White;
            Write("Yes / No");
            input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Write("Well, " + hero.name + ", nice to meet you.");
                Thread.Sleep(500);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Write("Your name: ");
                hero.name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Write("Well, " + hero.name + ", nice to meet you.");
                Thread.Sleep(500);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Write("She has a small grin on her face.");
            Write("Only now you've realized she has almost pale eyes, almost ghostly.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Write(hero.name + ", we have to move.");
            Write("You're lucky enough to be alive, so let's not take this for granted.");



            EnemyCharacter enemy = new EnemyCharacter("Ratatat", 500, 100, 50, 10, 25, 5, 1, 5, "Your clothes are filthy, and there's cuts and blood all over your body", 0);
            Battle openingBattle = new Battle(hero, enemy);
            openingBattle.BattleTurnBased();

        }
    }
}
