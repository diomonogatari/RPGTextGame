using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    class EnemyCharacter : AbstractCharacter
    {
        public EnemyCharacter(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, string Description, int Experience, ConsoleColor Color) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT, Description, Experience, Color)
        {
            this.bag = new List<Item>();
            this.abilityList = new List<Abilities>();
            this.equips = new List<EquipableItem>();
        }
        //create more constructors to add objects to list, since enemies are live generated
        public EnemyCharacter(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, string Description, int Experience, ConsoleColor Color, List<Item> Bag, List<Abilities> AbilityList, List<EquipableItem> Equips) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT, Description, Experience, Color)
        {
            this.bag = Bag;
            this.abilityList = AbilityList;
            this.equips = Equips;

        }


        public override void Explore()
        {
            throw new NotImplementedException();
        }

        public override void LookItem(Item item)
        {
            throw new NotImplementedException();
        }

        public override void LookSelf()
        {
            throw new NotImplementedException();
        }
    }
}
