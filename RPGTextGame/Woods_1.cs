using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    class Woods_1
    {
        public Woods_1(CharacterHero hero)
        {
            this.hero = hero;
        }

        CharacterHero hero;
        string input = "";

        public void Woodsini()
        {
            Core.Write("You're walking in an almost pitch black forest.");
            Core.Write("You can barely see a feet in front of you");
            Core.Write("In front of you there's a light in the distance with a bright shade of orange.");
            Core.Write("To your left there's complete darkness.");
            Core.Write("To your right there's a path that seems to have been used a lot in the past.");
            Core.Write("What do you do?");
            Core.Write("Left / Forward / Right ");
            input = Console.ReadLine();

            if (input.ToLower() == "left")
            {
                Core.Write("You decide to go left.");
                Woodsleft();
            }

            if (input.ToLower() == "forward")
            {
                Core.Write("You decide to go forward.");
            }

            if (input.ToLower() == "right")
            {
                Core.Write("You decide to go right.");
            }
            }

        public void Woodsleft()
        {
            Core.Write("You're walking in complete darkness.");
            Core.Write("You step on something slimy. Yuck!");
            Core.Write("There's a rotten smell in the air that keeps getting stronger.");
            Core.Write("Do you turn back or continue forward?");
            Core.Write("Back / Forward");
            input = Console.ReadLine();

            if (input.ToLower() == "back")
            {
                Core.Write("You decide to go back.");
                Woodsini();
            }

            if (input.ToLower() == "forward")
            {
                Core.Write("You decide to go forward.");
            }
        }
    }
}
