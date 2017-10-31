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
        static void Main(string[] args)
        {
            Write(intro);
            Console.Read();
            
        }
        private static void Write(String text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
        }
    }
}
