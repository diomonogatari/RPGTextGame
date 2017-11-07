using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    class Woods_1
    {
        CharacterHero hero;
        public Woods_1(CharacterHero Hero)
        {
            this.hero = Hero;
        }



        public void Woodsini()
        {
            Core.Write("You're walking in an almost pitch black forest.");
            Core.Write("You can barely see a feet in front of you");
            Core.Write("In front of you there's a light in the distance with a bright shade of orange.");
            Core.Write("To your left there's complete darkness.");
            Core.Write("To your right there's a path that seems to have been used a lot in the past.");
            Core.Write("What do you do?");
            Core.Write("Left / Forward / Right ");

            if (Core.Read().ToLower() == "left")
            {
                Core.Write("You decide to go left.");
                Woodsleft();
            }

            if (Core.Read().ToLower() == "forward")
            {
                Core.Write("You decide to go forward.");
            }

            if (Core.Read().ToLower() == "right")
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
            

            if (Core.Read().ToLower() == "back")
            {
                Core.Write("You decide to go back.");
                Woodsini();
            }

            if (Core.Read().ToLower() == "forward")
            {
                Core.Write("You decide to go forward.");
            }
        }
    }
}
