using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
	public class SortByMinValueDecrease: IComparer<int[]>
	{
		public int Compare(int[] firstElem, int[] secondElem)
		{
			return secondElem.Min() - firstElem.Min();
		}
	}
}
