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
            bag = new List<Item>();
            abilityList = new List<Abilities>();
            equips = new List<EquipableItem>();
        }
        //create more constructors to add objects to list, since enemies are live generated

        public override void Equip(EquipableItem equipable)
        {
            throw new NotImplementedException();
        }

        public override void Explore()
        {
            throw new NotImplementedException();
        }

        public override void LookItem(UsableItem usable)
        {
            throw new NotImplementedException();
        }

        public override void LookSelf()
        {
            throw new NotImplementedException();
        }

        public override void UseItem(UsableItem usable)
        {
            throw new NotImplementedException();
        }
    }
}
