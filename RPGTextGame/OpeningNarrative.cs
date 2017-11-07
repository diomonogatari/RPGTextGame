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
        CharacterHero hero;
        public OpeningNarrative(CharacterHero Hero)
        {
            this.hero = Hero;
        }
        ConsoleColor white = ConsoleColor.White;
        ConsoleColor magenta = ConsoleColor.Magenta;
        ConsoleColor darkblue = ConsoleColor.DarkBlue;
        public void Start()
        {
            Thread.Sleep(500);
            Core.Write("...");
            Thread.Sleep(1000);
            Core.Write("...");
            Thread.Sleep(1000);
            Core.Write("'Hello?!'");
            Thread.Sleep(1000);
            Core.Write("'Is someone there?!'");
            Thread.Sleep(1000);
            Core.Write("You hear footsteps coming towards you.");
            Thread.Sleep(1000);
            Core.Write("'What the... How...'");
            Thread.Sleep(500);
            Core.Write("'Are you alive? Fucks sake, WE HAVE TO GO!'");
            Thread.Sleep(500);
            Core.Write("You see a hand reaching out to you.");
            Thread.Sleep(500);
            Core.Write("Suddenly, you start to black out...");
            Thread.Sleep(1500);
        }

        public void Chapter1()
        {
            Console.BackgroundColor = darkblue;
            Thread.Sleep(1500);
            Core.Write("Rain is falling on your face.", white);
            Thread.Sleep(2500);
            Console.BackgroundColor = ConsoleColor.Black;
            Core.Write("You can't remember the last time you felt rain, or saw the sky for that matter.", white);
            Thread.Sleep(1000);
            Core.Write("Now that you think about it, you can't remember much at all.");
            Thread.Sleep(1000);
            Core.Write("Someone is sitting next to you. They haven't noticed you've woken up yet.");
            Thread.Sleep(1000);
            Core.Write("You notice that this person has red hair. You've never seen hair like this.");
            Thread.Sleep(1000);
            Core.Write("Red, almost like it was covered in blood. It sends a chill down your spine.");
            Thread.Sleep(1000);
            Core.Write("'Oh, you're awake.'", magenta);
            Thread.Sleep(1000);
            Core.Write("You realize this person is talking to you.", white);
            Thread.Sleep(1000);
            Core.Write("'You're lucky you made it out of there alive, you know?'", magenta);
            Thread.Sleep(1000);
            Core.Write("You're speechless. You finally get a glimpse of this person's face.", white);
            Thread.Sleep(1000);
            Core.Write("She has strong features, some scars, yet her face is delicate.");
            Thread.Sleep(1000);
            Core.Write("She is skinny. Surprisingly skinny.");
            Core.Write("Yet, she has been sharpening a sword bigger than you.");
            Thread.Sleep(1000);
            Core.Write("'You do remember how to talk, right?'", magenta);
            Thread.Sleep(1000);
            Core.Write("Yes / No", white);

            if (Core.Read().ToLower() == "yes")
            {
                Core.Write("'Knew it.'", magenta);
                Thread.Sleep(1000);
            }
            else
            {
                Core.Write("'Yeah, right.'", magenta);
                Thread.Sleep(1000);
            }
            Core.Write("She stands up. She looks threatning on her feet.", white);
            Thread.Sleep(1000);
            Core.Write("'Need a hand?'", magenta);
            Thread.Sleep(1000);
            Core.Write("Yes / No", white);

            if (Core.Read().ToLower() == "yes")
            {
                Core.Write("'Here you go.'", magenta);
                Thread.Sleep(1000);
            }
            else
            {
                Core.Write("'Well, you're not going to stay sitting there. Come on.'", magenta);
                Thread.Sleep(1000);
            }
            Core.Write("She's stronger than she looks. She effortlessly helps you get up.", white);
            Thread.Sleep(1000);
            Core.Write("I'm Viola. Vi for short.", magenta);
            Thread.Sleep(500);
            Core.Write("Do you have a name?");
            Thread.Sleep(500);
            Core.Write("That was a weird question. You hadn't given much thought to it.", white);
            Thread.Sleep(500);
            Core.Write("You try to remember if you had a name...");
            Thread.Sleep(500);
            Core.Write("You name is: ");
            hero.name = Core.Read();
            Core.Write("'" + hero.name + ", is it?" + "", magenta);
            Core.Write("Yes / No", white);


            if (Core.Read().ToLower() == "yes")
            {
                Core.Write("Well, " + hero.name + ", nice to meet you.", magenta);
                Thread.Sleep(500);
            }
            else
            {
                Core.Write("Your name: ", white);
                hero.name = Core.Read();
                Core.Write("Well, " + hero.name + ", nice to meet you.", magenta);
                Thread.Sleep(500);
            }
            Core.Write("She has a small grin on her face.", white);
            Core.Write("Only now you've realized she has almost pale eyes, almost ghostly.");
            Core.Write("'" + hero.name + ", we have to move.'", magenta);
            Core.Write("'You're lucky enough to be alive, so let's not take this for granted.'");

            EnemyCharacter enemy = new EnemyCharacter("Ratatat", 500, 100, 50, 10, 25, 5, 1, 5, "Your clothes are filthy, and there's cuts and blood all over your body", 0, ConsoleColor.Red);
            Battle openingBattle = new Battle(hero, enemy);
            openingBattle.BattleTurnBased();

        }
    }
}
