using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	[Serializable]
	public abstract class BonusAlgorithm
	{
		public abstract int IncreaseBonus(int bonus, decimal sum);

		public abstract int DecreaseBonus(int bonus, decimal sum);
	}
}
