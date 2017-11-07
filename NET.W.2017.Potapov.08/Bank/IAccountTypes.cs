using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	public interface IAccountType
	{
		string Type
		{
			get;
		}

		int BonusIncrease
		{
			get;
		}

		int BonusDecrease
		{
			get;
		}
	}
}
