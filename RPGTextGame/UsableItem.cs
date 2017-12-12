using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPGTextGame
{
    public class UsableItem : Item
    {

        public UsableItem(string Name , string Description, string AfterUseDescription, TypesOfStats Stat, short AmountOfValueIncreased) : base(Description, AfterUseDescription,  Stat, AmountOfValueIncreased)
        {
            this.itemName = Name;
            isUsable = true;
        }
        
    }
}
