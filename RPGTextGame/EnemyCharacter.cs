using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace RPGTextGame
{
    class EnemyCharacter : AbstractCharacter
    {
        public EnemyCharacter(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, ushort Speed, string Description, int Experience, Color Color, ConsoleControl.ConsoleControl Console) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT, Speed, Description, Experience, Color, Console)
        {
            this.bag = new List<Item>();
            this.abilityList = new List<Abilities>();
            this.equips = new List<EquipableItem>();
        }
        //create more constructors to add objects to list, since enemies are live generated
        public EnemyCharacter(string Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, ushort Speed, string Description, int Experience, Color Color, ConsoleControl.ConsoleControl Console, List<Item> Bag, List<Abilities> AbilityList, List<EquipableItem> Equips) : base(Name, HP, Stamina, AttackDamage, MagicDamage, Armor, MagicResistence, Luck, INT,Speed, Description, Experience, Color, Console)
        {
            this.bag = Bag;
            this.abilityList = AbilityList;
            this.equips = Equips;

        }


        public override void Explore()
        {
            throw new NotImplementedException();
        }

        public override void LookItem(UsableItem usable)
        {
            throw new NotImplementedException();
        }


        public override void useAttack() //Enemy attack use
        {
            throw new NotImplementedException();
        }
    }
}
