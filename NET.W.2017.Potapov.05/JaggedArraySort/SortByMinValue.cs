using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
	public class SortByMinValue: IComparer<int[]>
	{
		public int Compare(int[] firstElem, int[] secondElem)
		{
			return firstElem.Min() - secondElem.Min();
		}
	}
}
