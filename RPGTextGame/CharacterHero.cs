using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    class CharacterHero : ICharacterMechanics
    {
        short HealthPoints { get; set; }
        short StaminaPoints { get; set; }
        short DamagePoints { get; set; }
        short LifeSpan { get; set; }
        short Armor { get; set; }
        short MagicResistence { get; set; }
        short MagicDamage { get; set; }
        short Luck { get; set; }
        public short Intelligence { get; set; }


        List<String> bag = new List<String>();
        


        public CharacterHero()
        {

        }
        
        public void ShowBag()
        {
            bag.Add("ItemTeste1");
            bag.Add("ItemTeste2");
            bag.Add("ItemTeste3");
            bag.Add("ItemTeste4");
            bag.Add("ItemTeste5");

            //returns the bag
            foreach (String s in bag)
                Program.Write(s);
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
