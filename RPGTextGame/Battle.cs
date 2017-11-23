﻿using System;
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
        StringBuilder intro = new StringBuilder("A ");
        bool battleEnded = false;
        //Todo: a "database" of prefixed values to randomize and input in the battle scenarios
        //Todo: a flee command
        public Battle(CharacterHero hero, EnemyCharacter enemy)
        {
            this.hero = hero;
            this.enemy = enemy;
            callBattle();
        }
        int turn = 0;

        private void callBattle()
        {
            while (!isSomeoneDead() && turn != 0)
            { //cycle end if someone died and the turn is not 0
                if (turn == 0)
                    Core.Write(intro.Append(enemy.name).Append(" aproaches you. \n").Append(enemy.description).ToString());
                else
                {

                }
            }

        }
        private bool isSomeoneDead()
        {
            if (hero.health == 0)
            {
                Core.Write("You died");
                battleEnded = true;
                return true;
            }
            if (enemy.health == 0)
            {
                Core.Write("Your opponent was defeated");
                battleEnded = true;
                return true;
            }
            return false;//battle keeps going
        }
        private void battleLoot()
        {

        }
        private void checkActions(string actionToCheck)
        {
            if(actionToCheck == "")
            {
                //randomize the action
            }
            else
            {
                switch (actionToCheck)
                {
                    case "banana":
                        
                        break;
                }
            }

        }
        private void checkWhoIsFirst()
        {
            if (hero.speed > enemy.speed)
            {
                string instruction = Core.Read();
                checkActions(instruction);
            }
            else
            {
                checkActions("");
            }
        }



        public void BattleTurnBased()
        {
            Core.Write("A wild " + enemy.name + " appears!");
            while (enemy.health > 0 && hero.health > 0)
            {
                while (turn == 0)
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
