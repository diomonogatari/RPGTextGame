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
        CharacterHero hero;
        EnemyCharacter enemy;
        public Battle(CharacterHero hero, EnemyCharacter enemy)
        {
            this.hero = hero;
            this.enemy = enemy;
        }
        int yourTurn = 1;

        
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
                    if (Core.Read() == "1")
                    {
                        hero.MoveList();
                        Core.Write("Your command: ");
                        
                        if (Core.Read() == "1")
                        {
                            hero.MoveList();
                        }

                    }
                }
            }
        }
    }
}
