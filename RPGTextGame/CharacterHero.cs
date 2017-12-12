using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    public class CharacterHero : AbstractCharacter
    {

        public CharacterHero(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, string Description, int Experience, ConsoleColor Color) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT, Description, Experience, Color)
        {
            abilityList = new List<Abilities>();
            equips = new List<EquipableItem>();
            bag = new List<Item>();
            
        }

        public void ShowBag()
        {
            //returns the bag
            foreach (Item s in bag)
                Core.Write(s.description);
        }

        public void MoveList()
        {
            #region this is also for debugging
            abilityList.Add(new Abilities("Sword Slash", "You swing your sword at the target", 50, 100, "Physical"));
            abilityList.Add(new Abilities("Shield Bash", "You slam your shield in your target's face", 75, 80, "Physical"));
            #endregion 

            foreach (Abilities s in abilityList)
                Core.Write(s.abilityName + " , " + s.description);
            
        }

        public override void LookSelf()
        {
            Core.Write(this.description);
        }

        public override void LookItem(Item item)
        {
            Console.WriteLine(item.description);
        }

        public override void Explore()
        {
            throw new NotImplementedException();
        }
        public void Walk()
        {

        }
    }
}
