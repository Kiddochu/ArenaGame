using System;

namespace ArenaGame.Weapons
{
    public class MagicBook : IWeapon
    {
        public string Name { get; set; }
        public int AttackDamage { get; private set; }

        public MagicBook(string name)
        {
            Name = name;
            AttackDamage = 10; 
        }

        public void Attack(Enemy enemy)
        {
            enemy.Health -= AttackDamage;
            enemy.Health = Math.Max(enemy.Health, 0);
        }
    }

    public interface IWeapon
    {
        void Attack(Enemy enemy);
    }

    public class Player
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
    }

    public class Enemy
    {
        public int Health { get; set; }
    }
}
