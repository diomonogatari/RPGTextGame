using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPGTextGame
{
    class UsableItem : Item
    {
        short amountOfValueIncreased;

        public UsableItem(string Description, string AfterUseDescription, bool Usable, bool Equipable, TypesOfStats Stat, short AmountToIncrease) : base(Description, AfterUseDescription, Usable, Equipable, Stat)
        {
            this.amountOfValueIncreased = AmountToIncrease;
        }
    }
}
