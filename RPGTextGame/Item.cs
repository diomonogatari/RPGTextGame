using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    abstract public class Item
    {
        //what do all items have?
        //a description
        //a after use description
        //Should items have colors acording to their rarity?
        
        public string itemName { get; set; }
        public string description { get; set; }
        public string afterUseDescription { get; set; }
        public bool isUsable { get; set; }
        public bool isEquipable { get; set; }
        public TypesOfStats statToIncrease { get; set; }
        public short amountOfValueIncreased { get; set; }

        public Item(string ItemName, string Description, string AfterUseDescription, bool Usable, bool Equipable,short AmountOfValueIncreased, TypesOfStats Stat)
        {
            this.itemName = ItemName;
            this.description = Description;
            this.afterUseDescription = AfterUseDescription;
            this.isUsable = Usable;
            this.isEquipable = Equipable;
            this.statToIncrease = Stat;
            this.amountOfValueIncreased = AmountOfValueIncreased;
        }
        public Item(string Description, string AfterUseDescription, TypesOfStats Stat, short AmountOfValueIncreased)
        {
            this.itemName = itemName;
            this.description = Description;
            this.afterUseDescription = AfterUseDescription;
            this.statToIncrease = Stat;
            this.amountOfValueIncreased = AmountOfValueIncreased;
        }
    }
}
