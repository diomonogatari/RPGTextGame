using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RPGTextGame
{
    public class CharacterHero : AbstractCharacter
    {

        public CharacterHero(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, ushort Speed, string Description, int Experience, Color Color, ConsoleControl.ConsoleControl Console) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT, Speed, Description, Experience, Color, Console)
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
            EquipableItem HermesShoes = new EquipableItem("Hermes Shoes", "Fast as hell boys", TypesOfStats.Luck, EquipableItem.TypeOfEquip.Boots, 30);
            bag.Add(HermesShoes);

            //returns the bag
            foreach (Item s in bag)
                Core.Write(s.description, console, Color.White);
            Equip(HermesShoes);
        }

        public void MoveList()
        {
            #region this is also for debugging
            abilityList.Add(new Abilities("Sword Slash", "You swing your sword at the target", 50, 100, Abilities.AbilityType.Physical));
            abilityList.Add(new Abilities("Shield Bash", "You slam your shield in your target's face", 75, 80, Abilities.AbilityType.Physical));
            #endregion 

            foreach (Abilities s in abilityList)
                Core.Write(s.abilityName + " , " + s.description, console, Color.White);
            
        }

        public override void Explore()
        {
            throw new NotImplementedException();
        }
        public override void useAttack()
        {
            
        }
    }
}
