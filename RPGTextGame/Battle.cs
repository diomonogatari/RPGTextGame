using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPGTextGame
{
    class Battle
    {
        public Battle(CharacterHero hero, EnemyCharacter enemy)
        {
            this.hero = hero;
            this.enemy = enemy;
        }

        int yourTurn = 1;
        String command = "";
        
        CharacterHero hero;
        EnemyCharacter enemy;
        
        public void BattleTurnBased()
        {
            Core.Write("A wild " + enemy.name + " appears!");
            while (enemy.health > 0 && hero.health > 0)
            {
                while (yourTurn == 1)
                {
                    Core.Write("Your HP: " + hero.health);
                    Core.Write("Their HP: " + enemy.health);
                    Core.Write("What do you do? ");
                    Core.Write("Attack = 1 ");
                    Core.Write("Magic Spell = 2 ");
                    command = Console.ReadLine();
                    if (command == "1")
                    {
                        Core.Write("Which attack will you choose?");
                        Core.Write("Slap - 1 (Deals 25 damage, 100% hit, + modifier)");
                        Core.Write("Punch - 2 (Deals 50 damage, 80% hit, + modifier)");
                        Core.Write("Roundhouse Kick - 3 (Deals 80 damage, 70% hit, + modifier, but you take 25 damage)");
                        Core.Write("Focus - 4 (Increases your attack modifier by 0.5)");
                        Core.Write("Cancel - 5");
                        Core.Write("Your command: ");
                        command = Console.ReadLine();
                        if (command == "1")
                        {

                        }

                    }
                }
            }
        }
    }
}
