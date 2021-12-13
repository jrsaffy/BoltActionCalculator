using System;

namespace BoltActionCalculator
{
	public class Weapon
	{
		public int range;
		public int numAttacks;
		public int minRange;
		public int penetration;


		public Weapon(int _range, int num_attacks, int min_range = 0, int _penetration = 0)
		{
			this.range = _range;
			this.numAttacks = num_attacks;
			this.minRange = min_range;
			this.penetration = _penetration;
		}

	}
}
