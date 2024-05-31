using System;

namespace ArenaGame.Heroes
{
	public class Tank : Hero
	{
		private double spearDamageCoef;

		public Tank(string name, double armor, double strength, IWeapon weapon) : base(name, armor, strength, weapon)
		{
			spearDamageCoef = 1.5; 
		}

		public override double Attack()
		{
			double spearDamage = base.Attack() * spearDamageCoef;

			spearDamageCoef = 1.5;

			return spearDamage;
		}

		public override double Defend(double damage)
		{
			double armorEffectiveness = armor / (armor + 50); 
			double reducedDamage = damage * (1 - armorEffectiveness);

			return reducedDamage;
		}

	}
}
