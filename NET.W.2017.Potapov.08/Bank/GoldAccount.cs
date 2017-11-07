using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	[Serializable]
	public class GoldAccount: IAccountType
	{
		private string type = "Gold";
		private int bonusIncrease = 15;
		private int bonusDecrease = 5;

		public string Type
		{
			get
			{
				return type;
			}
		}

		public int BonusIncrease
		{
			get
			{
				return bonusIncrease;
			}
		}

		public int BonusDecrease
		{
			get
			{
				return bonusDecrease;
			}
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
