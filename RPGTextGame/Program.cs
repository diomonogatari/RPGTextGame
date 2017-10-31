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
        static void Main(string[] args)
        {

            while (true)
            {
                command = Read();
                //interpertation of the command should be here
                Write(command/*commandReturn will replace command after interpertation is implemented*/);
            }

        }
        private static void Write(String text)
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
