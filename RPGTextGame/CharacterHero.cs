using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    class CharacterHero : ICharacterMechanics
    {
        short HealthPoints;
        short StaminaPoints;
        short DamagePoints;
        short LifeSpan;
        short Armor;
        short MagicResistence;
        short MagicDamage;
        short Luck;
        short Intelligence;
        List<Object> bag = new List<object>();

        public void ShowBag()
        {
            //return the bag items
        }

        public void Drink()
        {

        }

        public void Eat()
        {

        }

        public void Equip()
        {

        }

        public void LookSelf()
        {

        }

        public void Read()
        {

        }

        public void UseItem()
        {

        }

        public void Explore()
        {

        }
    }
}
