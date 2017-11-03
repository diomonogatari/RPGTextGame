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

        public string description { get; set; }
        public string afterUseDescription { get; set; }
        public bool isUsable { get; set; }
        public bool isEquipable { get; set; }
        public TypesOfStats statToIncrease { get; set; }

        public Item(string Description, string AfterUseDescription, bool Usable, bool Equipable, TypesOfStats Stat)
        {
            description = Description;
            afterUseDescription = AfterUseDescription;
            isUsable = Usable;
            isEquipable = Equipable;
            statToIncrease = Stat;
        }

    }
}
