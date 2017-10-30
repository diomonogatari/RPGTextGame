using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    interface ICharacterMechanics
    {
        void Explore();
        void Drink();
        void Eat();
        void UseItem();
        void Equip();
        void Read();
        void LookSelf();


    }
}
