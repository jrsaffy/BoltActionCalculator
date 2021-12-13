using System;
using static BoltActionCalculator.Weapon;

namespace BoltActionCalculator
{
	public class Soldier
	{
		public Weapon weapon;
		

		public Soldier(Weapon _weapon)
		{
			this.weapon = _weapon;
			
		}
	}
}
