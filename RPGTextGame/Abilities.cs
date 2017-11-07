using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    public class Abilities
    {

        public string abilityName { get; set; }
        public string description { get; set; }
        public int damage { get; set; }
        public int accuracy { get; set; }
        public string damageType { get; set; }
        

        public Abilities(string AbilityName, string Description, int Damage, int Accuracy, string DamageType)
        {
            abilityName = AbilityName;
            description = Description;
            damage = Damage;
            accuracy = Accuracy;
            damageType = DamageType;
        }
        
    }
}
