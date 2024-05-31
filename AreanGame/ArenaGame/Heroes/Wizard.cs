using System;

namespace ArenaGame.Heroes
{
    public class Wizard : Hero
    {
        private int spellCharges;
        private double spellDamageCoef;

        public Wizard(string name, double armor, double strength, IWeapon weapon) : base(name, armor, strength, weapon)
        {
            spellCharges = 3; 
            spellDamageCoef = 1.2; 
        }

        public override double Attack()
        {
            double spellDamage = base.Attack() * spellDamageCoef;

            spellCharges--;

            spellDamageCoef = 1.2;

            return spellDamage;
        }

        public override double Defend(double damage)
        {
            if (spellCharges > 0)
            {
                double reducedDamage = damage * 0.5;
                spellCharges--;
                return reducedDamage;
            }
            else
            {
                return base.Defend(damage);
            }
        }
    }
}
