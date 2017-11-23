using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    public abstract class NPCharacter : AbstractCharacter
    {
        public bool targatable = false;
        public NPCharacter(string Name,  string Description, short Age, ConsoleColor Color): base(Name, Description, Age, Color)
        {
            this.experience = int.MaxValue;
            this.magicResistence = short.MaxValue;
            this.magicDamage = short.MaxValue;
            this.attackDamage = short.MaxValue;
            this.armor = short.MaxValue;
            this.health = short.MaxValue;
            this.stamina = short.MaxValue;
        }


        public override void LookItem(UsableItem usable)
        {
            throw new NotImplementedException();
        }



        public override void useAttack()
        {
            throw new NotImplementedException();
        }
    }
}
