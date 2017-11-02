using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPGTextGame
{
    class Program
    {
        static String intro = "Greetings summoner \nprepare to die";
        static String command;
        static String commandReturn;
        static bool pressed = true;
        static void Main(string[] args)
        {
            CharacterHero hero = new CharacterHero();
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            do
            {
                while (!Console.KeyAvailable)
                {
                    //command = Read();
                    //if (command == "show bag".ToLower())
                    //    hero.ShowBag();
                    //else
                    //    Write(command/*commandReturn will replace command after interpertation is implemented*/);

                    Console.WriteLine(GameMechanics.DetermineChanceLevel());
                    //Thread.Sleep(3);

                }
            }while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.Read();

        }
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
    }
}
