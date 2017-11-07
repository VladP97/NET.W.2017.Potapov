using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	[Serializable]
	public class StandartBonusAlgorithm: BonusAlgorithm
	{
		public override int IncreaseBonus(int bonus, decimal sum)
		{
			return (int)(sum * bonus);
		}

		public override int DecreaseBonus(int bonus, decimal sum)
		{
			return(int)(sum * bonus);
		}
	}
}
