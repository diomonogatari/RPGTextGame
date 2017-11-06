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
        #endregion

        public static void Start()
        {
            String name;
            String input;
            Thread.Sleep(500);
            Write("...");
            Thread.Sleep(1000);
            Write("...");
            Thread.Sleep(1000);
            Write("'Hello?'");
            Thread.Sleep(1000);
            Write("'Is someone there?'");
            Thread.Sleep(1000);
            Write("You hear footsteps coming towards you.");
            Thread.Sleep(1000);
            Write("'Do you have a name?'");
            Thread.Sleep(500);
            Write("Your name: ");
            name = Console.ReadLine();
            Write("'" + name + ", is it?" + "");
            Write("Yes / No");
            input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                Write("Well, " + name + ", let's get you the fuck out of here.");
            }
            else
            {
                Write("Your name: ");
                name = Console.ReadLine();
                Write("Well, " + name + ", let's get you the fuck out of here.");
            }

            CharacterHero hero = new CharacterHero(name, 900, 100, 50, 10, 30, 35, 5, 10, "Wubba Lubba Dub Dub ayy lmao", 999);
            

        }
    }
}
