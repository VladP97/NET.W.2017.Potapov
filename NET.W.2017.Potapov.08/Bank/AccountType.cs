using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	public abstract class AccountType
	{
		protected int bonusIncrease;

		protected int bonusDecrease;

		protected IBonusAlgorithm algorithm;

		public IBonusAlgorithm Algorithm
		{
			get
			{
				return algorithm;
			}
			set
			{
				algorithm = value;
			}
		}

		public string Type
		{
			get;
		}

		public int BonusIncrease
		{
			get
			{
				return bonusDecrease;
			}
		}

		public int BonusDecrease
		{
			get
			{
				return bonusDecrease;
			}
		}

		public int IncreaseBonus(decimal sum)
		{
			return algorithm.IncreaseBonus(sum, bonusIncrease);
		}

		public int DecreaseBonus(decimal sum)
		{
			return algorithm.DecreaseBonus(sum , bonusDecrease);
		}
	}
}
