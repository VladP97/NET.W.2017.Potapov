using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSort
{
	public static class QuickSort
	{
		private static void Swap(ref int el1, ref int el2)
		{
			int copiedEl = el1;
			el1 = el2;
			el2 = copiedEl;
		}

		public static int[] Sort(int[] arr, int first, int last)
		{
			int begin = first;
			int end = last;
			int root = arr[(begin + end) / 2];
			while (begin <= end)
			{
				while (arr[begin] < root)
				{
					begin++;
				}
				while (arr[end] > root)
				{
					end--;
				}
				if (begin <= end)
				{
					Swap(ref arr[begin++], ref arr[end--]);
				}
			}
			if (first < end)
			{
				Sort(arr, first, end);
			}
			if (last > begin)
			{
				Sort(arr, begin, last);
			}
			return arr;
		}
	}
}
