using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Spear : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double ArmorPenetration { get; private set; }

        public Spear(string name)
        {
            Name = name;
            AttackDamage = 40;
            ArmorPenetration = 0.25; 
        }

        public double CalculatePiercingStrikeDamage(double targetArmor)
        {
            double effectiveArmor = targetArmor * (1 - ArmorPenetration);
            double damageDealt = AttackDamage - effectiveArmor;

            return Math.Max(damageDealt, 0);
        }
    }
}
