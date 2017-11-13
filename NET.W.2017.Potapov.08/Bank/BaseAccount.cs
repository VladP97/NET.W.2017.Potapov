using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	[Serializable]
	public class BaseAccount : AccountType
	{
		private string type = "Base";

		public BaseAccount(IBonusAlgorithm algorithm)
		{
			this.algorithm = algorithm;
			bonusDecrease = 15;
			bonusIncrease = 15;
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
