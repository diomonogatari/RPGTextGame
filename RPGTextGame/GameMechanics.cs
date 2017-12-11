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

        public static String DetermineChanceLevel(CharacterHero hero)
        {

            Thread.Sleep(1);
            outputGenerated = seedGenerator.Next(1001);

            #region Limits of change regions
            int badLowerLimit = (int)(100 - (hero.luck * 1.5)) <= 0 ? 1 : (int)(100 - (hero.luck * 1.5));
            int badUpperLimit = (int)(900 + (hero.luck * 1.5)) >= 1000 ? 999 : (int)(900 + (hero.luck * 1.5));

            int neutralLowerLimit = (badLowerLimit + 200) - hero.luck;
            int neutralUpperLimit = (badUpperLimit - 200) + hero.luck;

            int goodLowerLimit = (neutralLowerLimit + 150) - hero.luck;
            int goodUpperLimit = (neutralUpperLimit - 150) + hero.luck;

            int greatLowerLimit = (goodLowerLimit + 90) - hero.luck / 2;
            int greatUpperLimit = (goodUpperLimit - 90) + hero.luck / 2;

            if (greatUpperLimit - greatLowerLimit <= 0)
            {
                greatLowerLimit = 494;
                greatUpperLimit = 505;
            }


            #endregion




            if (outputGenerated == -1)
                return "There was an error with the RNG";
            if (outputGenerated >= 0 && outputGenerated <= badLowerLimit || outputGenerated <= 1000 && outputGenerated >= badUpperLimit)
                return "bad";
            if (outputGenerated > badLowerLimit && outputGenerated <= neutralLowerLimit || outputGenerated < badUpperLimit && outputGenerated >= neutralUpperLimit)
                return "neutral";
            if (outputGenerated > neutralLowerLimit && outputGenerated <= goodLowerLimit || outputGenerated < neutralUpperLimit && outputGenerated >= goodUpperLimit)
                return "good";
            if (outputGenerated > goodLowerLimit && outputGenerated <= greatLowerLimit || outputGenerated < goodUpperLimit && outputGenerated >= greatUpperLimit)
                return "great";
            if (outputGenerated > greatLowerLimit && outputGenerated < greatUpperLimit)
                return "Legendary";
            return new Exception($"Value of chance cannot be determined(Value of output: {outputGenerated}").ToString();
        }
    }
}
