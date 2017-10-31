using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    class GameMechanics
    {
        Random seedGenerator = new Random();
        Random lastGenerator;
        int outputGenerated;
        public GameMechanics()
        {

        }
        private int CallRNGForChance(short luck, CharacterHero hero)
        {
            seedGenerator.Next();
            lastGenerator = new Random(luck + seedGenerator.Next());
            outputGenerated = lastGenerator.Next(101);
            if(outputGenerated >= 50 && outputGenerated+luck < 100)
            {
                //if(outputGenerated+luck > 100) if we want to be scumbags
                //{
                //    return 100;
                //}
                return outputGenerated + luck;
            }
            if (outputGenerated <= 50 && outputGenerated - luck < 0)
                return outputGenerated - luck;
            return -1;
        }
        public String DetermineChanceLevel(short luck, CharacterHero hero)
        {
            int generatedChance = CallRNGForChance(luck, hero);
            if (generatedChance >= 0 && generatedChance <= 20 || generatedChance <= 100 && generatedChance >= 80)
                return "bad";
            if (generatedChance >= 21 && generatedChance <= 40 || generatedChance <= 79 && generatedChance >= 60)
                return "neutral";
            if (generatedChance >= 41 && generatedChance <= 48 || generatedChance <= 59 && generatedChance >= 51)
                return "good";
            if (generatedChance == 49 || generatedChance == 50)
                return "great";
            return new Exception("Value of chance cannot be determined").ToString();
        }

    }
}
