using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    class EnemyCharacter : AbstractCharacter
    {

        List<Item> bag = new List<Item>();
        List<EquipableItem> equips = new List<EquipableItem>();

        public EnemyCharacter(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, string Description, int Experience) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT, Description, Experience)
        {

        }

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
