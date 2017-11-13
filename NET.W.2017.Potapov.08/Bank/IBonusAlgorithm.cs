using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	public interface IBonusAlgorithm
	{
		int IncreaseBonus(decimal sum, int increaseBonus);

		int DecreaseBonus(decimal sum, int decreaseBonus);
	}
}
