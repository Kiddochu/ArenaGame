using System;

namespace ArenaGame.Weapons
{
    public class Kunai : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double ThrowingPower { get; private set; }
        public bool CanTeleport { get; private set; } 

        public Kunai(string name)
        {
            Name = name;
            AttackDamage = 20; 
            ThrowingPower = 0.7; 
            CanTeleport = true; 
        }
    }
}