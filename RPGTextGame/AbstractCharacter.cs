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
        public short lifeSpan { get; set; } // how long is alive : age
        public short armor { get; set; }
        public short magicResistence { get; set; }
        public short magicDamage { get; set; }
        public short luck { get; set; }
        public short intelligence { get; set; }
        public string description { get; set; }
        public int experience { get; set; }
        public ushort speed { get; set; }
        public List<Item> bag;
        public List<Abilities> abilityList;
        public List<EquipableItem> equips;
        public ConsoleColor charColor;
        //Todo: Coin Purse missing
        //Todo: choosing an action in fight
        //Todo: perks missing
        //for abilities and attacks there should be a class
        //same applies for perks

        public void checkStatAndIncrease(TypesOfStats statToIncrease, /*Change to Item*/ Item item, AbstractCharacter character)
        {
            string output = character.name + "'s ";
            switch (statToIncrease)
            {
                case TypesOfStats.Armor:
                    character.armor += item.amountOfValueIncreased;
                    output += "Armor is now " + character.armor;
                    Core.Write(output);
                    break;
                case TypesOfStats.HP:
                    character.health += item.amountOfValueIncreased;
                    output += "Health is now " + character.health;
                    Core.Write(output);
                    break;
                case TypesOfStats.AttackDamage:
                    character.attackDamage += item.amountOfValueIncreased;
                    output += "Attack Damage is now " + character.attackDamage;
                    Core.Write(output);
                    break;
                case TypesOfStats.MagicDamage:
                    character.magicDamage += item.amountOfValueIncreased;
                    output += "Magic Damage is now " + character.magicDamage;
                    Core.Write(output);
                    break;
                case TypesOfStats.MagicResistence:
                    character.magicResistence += item.amountOfValueIncreased;
                    output += "Magic Resistence is now " + character.magicResistence;
                    Core.Write(output);
                    break;
                case TypesOfStats.Stamina:
                    character.stamina += item.amountOfValueIncreased;
                    output += "Stamina is now " + character.armor;
                    Core.Write(output);
                    break;
                case TypesOfStats.Luck:
                    character.luck += item.amountOfValueIncreased;
                    output += "Luck is now " + character.armor;
                    Core.Write(output);
                    break;
                case TypesOfStats.Intelligence:
                    character.intelligence += item.amountOfValueIncreased;
                    output += "Intelligence is now " + character.armor;
                    Core.Write(output);
                    break;
                case TypesOfStats.Experience:
                    character.experience += item.amountOfValueIncreased;
                    output += "Experience is now " + character.armor;
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

        public AbstractCharacter(String Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, short Luck, short INT, ushort Speed, string Description, int Experience, ConsoleColor Color) //Full Creation
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
            speed = Speed;
            charColor = Color;

        }
        public AbstractCharacter(String Name, string Description, short Age, ConsoleColor Color) //NPC Creation
        {
            name = Name;
            lifeSpan = Age;
            description = Description;
            charColor = Color;

        }
        public AbstractCharacter(String Name, short HP, short Stamina, short AttackDamage, short MagicDamage, short Armor, short MagicResistence, string Description, ushort Speed, int Experience, ConsoleColor Color) //Enemy creation
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
            speed = Speed;
            charColor = Color;

        }
        public void Equip(EquipableItem equipable)
        {
            if (equipable.isEquipable && bag.Contains(equipable)/*and if it's in the bag available to be equiped*/)
            {
                int index = bag.IndexOf(equipable);//register the index where the item is
                EquipableItem itemInsideBag = (EquipableItem)bag[index];//make a copy of the item inside of the bag to put it back in after updating equip states
                if (!itemInsideBag.isEquiped)//if the state of the item that is in the bag is not true (it's not equiped)
                {
                    //then equip it
                    Core.Write(equipable.afterUseDescription);
                    itemInsideBag.isEquiped = true;
                    checkStatAndIncrease(equipable.statToIncrease, equipable, this);//non tested
                    bag.Remove(equipable);
                    bag.Insert(index, itemInsideBag);
                }
                else
                    Core.Write("Item is already equiped");//else it's already equiped

            }
            else
                Core.Write("Item is not equipable/in bag");
        }
        public virtual void Explore() { }
        public virtual void LookItem(UsableItem usable)
        {
            Core.Write(usable.description);
        }
        public void LookSelf()
        {
            Core.Write(this.description);
        }
        public void UseItem(UsableItem usable)
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
        public virtual void useAttack()
        {

        }

    }
}
