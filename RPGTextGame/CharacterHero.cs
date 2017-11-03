using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    public class CharacterHero : AbstractCharacter
    {


        List<String> bag = new List<String>();

        public CharacterHero(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, string Description, int Experience) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT, Description, Experience)
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
                Core.Write(s);
        }



        public override void Equip(EquipableItem equipable)
        {
            throw new NotImplementedException();
        } //ToDo After lunch

        public override void Explore()
        {
            throw new NotImplementedException();
        }

        public override void UseItem(UsableItem usable)
        {
            if (usable.isUsable)
            {
                Core.Write(usable.afterUseDescription);

                checkStatAndIncrease(usable.statToIncrease, usable, this);


            }
            else
                Core.Write("This Item is not usable");
        }

        public override void LookSelf()
        {
            Core.Write(this.description);
        }

        public override void LookItem(UsableItem usable)
        {
            Console.WriteLine(usable.description);
        }
    }
}
