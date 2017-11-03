using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPGTextGame
{
    public class UsableItem : Item
    {
        public short amountOfValueIncreased;

        public UsableItem(string Description, string AfterUseDescription, TypesOfStats Stat, short AmountToIncrease) : base(Description, AfterUseDescription,  Stat)
        {
            this.amountOfValueIncreased = AmountToIncrease;
            isUsable = true;
        }
    }
}
