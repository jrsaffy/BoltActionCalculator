using System;
using System.Collections.Generic;

namespace BoltActionCalculator
{
	public class Squad
	{
		public List<Soldier> soldiers = new List<Soldier>();
		public int numberOfSoldiers { get; set; }

		public int isDown = 0;

		public int morale;
		public int dieOn;

		public Squad(bool _isDown, string _vet, List<Soldier> _soldiers = null)
		{
			this.soldiers = _soldiers;
			this.numberOfSoldiers = soldiers.Count;
            if (_isDown)
            {
				this.isDown = -2;
            }

			if (_vet == "Inexperienced")
			{
				this.morale = 8;
				this.dieOn = 4;
			}
			if (_vet == "Regular")
			{
				this.morale = 9;
				this.dieOn = 5;
			}
			if (_vet == "Veteran")
			{
				this.morale = 10;
				this.dieOn = 6;
			}

		}
	}
}
