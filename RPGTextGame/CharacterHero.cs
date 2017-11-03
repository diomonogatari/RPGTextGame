using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    public class CharacterHero : AbstractCharacter
    {


        List<Item> bag = new List<Item>();

        public CharacterHero(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, string Description, int Experience) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT, Description, Experience)
        {

        }

        public void ShowBag()
        {
            #region This is for debugging
            bag.Add(new UsableItem("The power of Odin", "You feel the rage of the Gods flow through your body", TypesOfStats.AttackDamage, 40));
            bag.Add(new UsableItem("Lightning of Thor", "You can bend the lightning to your will", TypesOfStats.Armor, 40));
            bag.Add(new UsableItem("Rage of Sparta", "No can hold you now", TypesOfStats.Stamina, 40));
            bag.Add(new UsableItem("Poseidon Scepter", "The tides are no match to your mind", TypesOfStats.MagicDamage, 40));
            bag.Add(new UsableItem("Strength of the Colossi", "The Unstopable strength that holds the world from the sky is now yours", TypesOfStats.HP, 40));
            #endregion

            //returns the bag
            foreach (Item s in bag)
                Core.Write(s.description);
        }



        public override void Equip(EquipableItem equipable)
        {
            throw new NotImplementedException();
        }

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
