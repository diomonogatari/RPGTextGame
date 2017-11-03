using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    public interface ICharacterMechanics
    {
        void Explore();
        void UseItem(UsableItem usable);
        void Equip(EquipableItem equipable);
        void LookSelf();
        void LookItem(UsableItem usable);
    }
}
