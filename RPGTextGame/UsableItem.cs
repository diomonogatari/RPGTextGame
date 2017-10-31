using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPGTextGame
{
    class UsableItem
    {
        bool isUsable = true;
        String itemDescription = "";
        String afterUsingReturnDescription = "";
        short amountOfValueIncreased;
        // HP, AD, AP, Armor, MagicRes, Stamina, Luck, Intelligence (0 to inf...)
        //if null there is no stat increase
        short? statToIncrease;



        public UsableItem(String description, String afterUse, short enumOfTheStatToIncrease)
        {
            this.itemDescription = description;
            this.afterUsingReturnDescription = afterUse;
            this.statToIncrease = enumOfTheStatToIncrease;
        }

    }
}
