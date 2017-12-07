using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace RPGTextGame
{
    class OpeningNarrative
    {
        CharacterHero hero;
        ConsoleControl.ConsoleControl console;
        UI ui;
        public OpeningNarrative(CharacterHero Hero)
        {
            this.hero = Hero;
            this.console = Hero.console;
            ui = (UI)console.Parent;
        }
        Color narratorColor = Color.White;
        Color friendColor = Color.Magenta;

        public void Start()
        {
            Thread.Sleep(500);
            Core.Write("...", console, hero.charColor);
            Thread.Sleep(1000);
            Core.Write("...", console, hero.charColor);
            Thread.Sleep(1000);
            Core.Write("'Hello?!'", console, hero.charColor);
            Thread.Sleep(1000);
            Core.Write("'Is someone there?!'", console, hero.charColor);
            Thread.Sleep(1000);
            Core.Write("You hear footsteps coming towards you.",console,narratorColor);
            Thread.Sleep(1000);
            Core.Write("'What the... How...'", console, hero.charColor);
            Thread.Sleep(500);
            Core.Write("'Are you alive? Fucks sake, WE HAVE TO GO!'", console, friendColor);
            Thread.Sleep(500);
            Core.Write("You see a hand reaching out to you.", console, narratorColor);
            Thread.Sleep(500);
            Core.Write("Suddenly, you start to black out...",console,narratorColor);
            Thread.Sleep(1500);
        }

        public void Chapter1()
        {
            Thread.Sleep(1500);
            Core.Write("Rain is falling on your face.", console, narratorColor);
            Thread.Sleep(2500);
            Console.BackgroundColor = ConsoleColor.Black;
            Core.Write("You can't remember the last time you felt rain, or saw the sky for that matter.", console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("Now that you think about it, you can't remember much at all.",console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("Someone is sitting next to you. They haven't noticed you've woken up yet.",console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("You notice that this person has red hair. You've never seen hair like this.", console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("Red, almost like it was covered in blood. It sends a chill down your spine.", console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("'Oh, you're awake.'",console, friendColor);
            Thread.Sleep(1000);
            Core.Write("You realize this person is talking to you.", console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("'You're lucky you made it out of there alive, you know?'", console, friendColor);
            Thread.Sleep(1000);
            Core.Write("You're speechless. You finally get a glimpse of this person's face.", console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("She has strong features, some scars, yet her face is delicate.",console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("She is skinny. Surprisingly skinny.",console, narratorColor);
            Core.Write("Yet, she has been sharpening a sword bigger than you.",console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("'You do remember how to talk, right?'", console, friendColor);
            Thread.Sleep(1000);
            Core.Write("Yes / No", console, friendColor);

            //if (Core.Read(ui).ToLower() == "yes")
            //{
            //    Core.Write("'Knew it.'", console, friendColor);
            //    Thread.Sleep(1000);
            //}
            //else
            //{
            //    Core.Write("'Yeah, right.'", console, friendColor);
            //    Thread.Sleep(1000);
            //}
            Core.Write("She stands up. She looks threatning on her feet.", console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("'Need a hand?'", console, friendColor);
            Thread.Sleep(1000);
            Core.Write("Yes / No", console, narratorColor);

            //if (Core.Read().ToLower() == "yes")
            //{
            //    Core.Write("'Here you go.'", console, friendColor);
            //    Thread.Sleep(1000);
            //}
            //else
            //{
            //    Core.Write("'Well, you're not going to stay sitting there. Come on.'", console, friendColor);
            //    Thread.Sleep(1000);
            //}
            Core.Write("She's stronger than she looks. She effortlessly helps you get up.", console, narratorColor);
            Thread.Sleep(1000);
            Core.Write("I'm Viola. Vi for short.", console, friendColor);
            Thread.Sleep(500);
            Core.Write("Do you have a name?",console, friendColor);
            Thread.Sleep(500);
            Core.Write("That was a weird question. You hadn't given much thought to it.", console, narratorColor);
            Thread.Sleep(500);
            Core.Write("You try to remember if you had a name...",console, narratorColor);
            Thread.Sleep(500);
            Core.Write("You name is: ", console, narratorColor);
            //hero.name = Core.Read();
            Core.Write("'" + hero.name + ", is it?" + "", console, friendColor);
            Core.Write("Yes / No", console, narratorColor);


            //if (Core.Read().ToLower() == "yes")
            //{
            //    Core.Write("Well, " + hero.name + ", nice to meet you.", console, friendColor);
            //    Thread.Sleep(500);
            //}
            //else
            //{
            //    Core.Write("Your name: ", console, narratorColor);
            //    hero.name = Core.Read();
            //    Core.Write("Well, " + hero.name + ", nice to meet you.", console, friendColor);
            //    Thread.Sleep(500);
            //}
            Core.Write("She has a small grin on her face.", console, narratorColor);
            Core.Write("Only now you've realized she has almost pale eyes, almost ghostly.",console, narratorColor);
            Core.Write("'" + hero.name + ", we have to move.'", console, friendColor);
            Core.Write("'You're lucky enough to be alive, so let's not take this for granted.'",console, friendColor);

            //    EnemyCharacter enemy = new EnemyCharacter("Ratatat", 500, 100, 50, 10, 25, 5, 1, 5,10, "Your clothes are filthy, and there's cuts and blood all over your body", 0, ConsoleColor.Red);
            //    Battle openingBattle = new Battle(hero, enemy);
            //    openingBattle.BattleTurnBased();

        }
        }
}
