using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	public class StandartAlgorithm: IBonusAlgorithm
	{
		public int IncreaseBonus(decimal sum, int increaseBonus)
		{
			return (int)(sum / increaseBonus * 10);
		}

		public int DecreaseBonus(decimal sum, int decreaseBonus)
		{
			return (int)(sum / decreaseBonus * 10);
		}
	}
}
