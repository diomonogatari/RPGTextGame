using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    public abstract class AbstractCharacter : ICharacterMechanics
    {
        public string name { get; set; }
        public short health { get; set; }
        public short stamina { get; set; }
        public short attackDamage { get; set; }
        public short lifeSpan { get; set; }
        public short armor { get; set; }
        public short magicResistence { get; set; }
        public short magicDamage { get; set; }
        public short luck { get; set; }
        public short intelligence { get; set; }
        public string description { get; set; }
        public int experience { get; set; }
        public List<Item> bag;
        public List<Abilities> abilityList;
        public List<EquipableItem> equips;
        //abilities missing
        //attacks missing
        //choosing an action in fight
        //perks missing
        //for abilities and attacks there should be a class
        //same applies for perks

        public void checkStatAndIncrease(TypesOfStats statToIncrease, /*Change to Item*/ UsableItem item, CharacterHero hero)
        {
            string output = hero.name + "'s ";
            switch (statToIncrease)
            {
                case TypesOfStats.Armor:
                    hero.armor += item.amountOfValueIncreased;
                    output += "armor is now " + hero.armor;
                    Core.Write(output);
                    break;
                case TypesOfStats.HP:
                    hero.health += item.amountOfValueIncreased;
                    output += "Health is now " + hero.health;
                    Core.Write(output);
                    break;
                case TypesOfStats.AttackDamage:
                    hero.attackDamage += item.amountOfValueIncreased;
                    output += "Attack Damage is now " + hero.attackDamage;
                    Core.Write(output);
                    break;
                case TypesOfStats.MagicDamage:
                    hero.magicDamage += item.amountOfValueIncreased;
                    output += "Magic Damage is now " + hero.magicDamage;
                    Core.Write(output);
                    break;
                case TypesOfStats.MagicResistence:
                    hero.magicResistence += item.amountOfValueIncreased;
                    output += "Magic Resistence is now " + hero.magicResistence;
                    Core.Write(output);
                    break;
                case TypesOfStats.Stamina:
                    hero.stamina += item.amountOfValueIncreased;
                    output += "Stamina is now " + hero.armor;
                    Core.Write(output);
                    break;
                case TypesOfStats.Luck:
                    hero.luck += item.amountOfValueIncreased;
                    output += "Luck is now " + hero.armor;
                    Core.Write(output);
                    break;
                case TypesOfStats.Intelligence:
                    hero.intelligence += item.amountOfValueIncreased;
                    output += "Intelligence is now " + hero.armor;
                    Core.Write(output);
                    break;
                case TypesOfStats.Experience:
                    hero.experience += item.amountOfValueIncreased;
                    output += "Experience is now " + hero.armor;
                    Core.Write(output);
                    break;
                case TypesOfStats.None:
                    break;//Should we say something?
                case TypesOfStats.Invalid:
                    Console.WriteLine("Error: Invalid stat type");
                    break;
                default:
                    break;
            }
        }

        public AbstractCharacter(String Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, string Description, int Experience)
        {
            name = Name;
            health = HP;
            stamina = Stamina;
            attackDamage = AttackDamage;
            lifeSpan = 0;
            armor = Armor;
            magicResistence = MagicResistence;
            magicDamage = MagicDamage;
            luck = Luck;
            intelligence = INT;
            description = Description;
            experience = 0;
        }
        public AbstractCharacter(String Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, string Description, int Experience)
        {
            name = Name;
            health = HP;
            stamina = Stamina;
            attackDamage = AttackDamage;
            lifeSpan = 0;
            armor = Armor;
            magicResistence = MagicResistence;
            magicDamage = MagicDamage;
            description = Description;
            experience = 0;
        }

        public abstract void Equip(EquipableItem equipable);
        public abstract void Explore();
        public abstract void LookItem(UsableItem usable);
        public abstract void LookSelf();
        public abstract void UseItem(UsableItem usable);
    }
}
