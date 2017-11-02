using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPGTextGame
{
    class GameMechanics
    {
        static Random seedGenerator = new Random();

        static int outputGenerated;

        public GameMechanics()
        {

        }
        //RNG IS A BIG SPAGHETTI CODE ATM

        public static String DetermineChanceLevel(/*short luckOnDetermine, CharacterHero hero/*/)
        {

            Thread.Sleep(1);
            outputGenerated = seedGenerator.Next(1001);

            //if (outputGenerated >= 50 && outputGenerated + luckOnDetermine < 100)
            //{
            //    //if(outputGenerated+luck > 100) if we want to be scumbags
            //    //{
            //    //    return 100;
            //    //}

            //    outputGenerated += luckOnDetermine;
            //}
            //if (outputGenerated <= 50 && outputGenerated - luckOnDetermine > 0)
            //    outputGenerated -= luckOnDetermine;











            if (outputGenerated == -1)
                return "There was an error with the RNG";
            if (outputGenerated >= 0 && outputGenerated <= 139 || outputGenerated <= 1000 && outputGenerated >= 870)
                return "bad";
            if (outputGenerated >= 140 && outputGenerated <= 409 || outputGenerated <= 869 && outputGenerated >= 600)
                return "neutral";
            if (outputGenerated >= 410 && outputGenerated <= 489 || outputGenerated <= 599 && outputGenerated >= 530)
                return "good";
            if (outputGenerated >= 490 && outputGenerated <= 500 || outputGenerated <= 529 && outputGenerated >= 506)
                return "great";
            if (outputGenerated >= 501 && outputGenerated <= 505)
                return "Legendary";
            return new Exception("Value of chance cannot be determined").ToString();
        }
    }
}
