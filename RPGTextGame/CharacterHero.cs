﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    public class CharacterHero : AbstractCharacter
    {      

        public CharacterHero(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, string Description, int Experience) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT, Description, Experience)
        {
            abilityList = new List<Abilities>();
            equips = new List<EquipableItem>();
            bag = new List<Item>();


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
            EquipableItem HermesShoes = new EquipableItem("Hermes Shoes", "Fast as hell boys", TypesOfStats.Luck, EquipableItem.TypeOfEquip.Boots);
            bag.Add(HermesShoes);

            //returns the bag
            foreach (Item s in bag)
                Core.Write(s.description);
            Equip(HermesShoes);
        }

        public void MoveList()
        {
            #region this is also for debugging KEK
            abilityList.Add(new Abilities("Sword Slash", "You swing your sword at the target", 50, 100, "Physical"));
            abilityList.Add(new Abilities("Shield Bash", "You slam your shield in your target's face", 75, 80, "Physical"));
            #endregion 

            foreach (Abilities s in abilityList)
                Core.Write(s.abilityName + " , " + s.description);
            
        }



        public override void Equip(EquipableItem equipable)
        {
            if (equipable.isEquipable && bag.Contains(equipable)/*and if it's in the bag available to be equiped*/)
            {
                int index = bag.IndexOf(equipable);
                EquipableItem itemInsideBag = (EquipableItem)bag[index];
                if (!itemInsideBag.isEquiped)
                {

                    Core.Write(equipable.afterUseDescription);
                    itemInsideBag.isEquiped = true;
                    //increasing stats to player is missing
                    bag.Remove(equipable);
                    bag.Insert(index, itemInsideBag);
                }
                else
                    Core.Write("Item is already equiped");

            }
            else
                Core.Write("Item is not equipable/in bag");
        }

        public override void Explore()
        {
            throw new NotImplementedException();
        }

        public override void UseItem(UsableItem usable)
        {

            if (usable.isUsable/*also has to check if it is in the bag*/)
            {
                Core.Write(usable.afterUseDescription);

                checkStatAndIncrease(usable.statToIncrease, usable, this);
                bag.Remove(usable);


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
