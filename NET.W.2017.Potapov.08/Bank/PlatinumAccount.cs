using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	[Serializable]
	public class PlatinumAccount: AccountType
	{
		private string type = "Platinum";

		public PlatinumAccount(IBonusAlgorithm algorithm)
		{
			this.algorithm = algorithm;
			bonusIncrease = 15;
			bonusDecrease = 0;
		}

		public override string ToString()
		{
			return type;
		}

		public override int GetHashCode()
		{
			return type.GetHashCode() + bonusIncrease + bonusDecrease;
		}
	}
}
