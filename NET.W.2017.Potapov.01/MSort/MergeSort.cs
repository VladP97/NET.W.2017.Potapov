using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSort
{
	public static class MergeSort
	{
		public static int[] Sort(int[] arr)
		{
			if (arr.Length == 1)
			{
				return arr;
			}
			int[] secondPartArr = new int[0];
			for (int i = arr.Length / 2; i < arr.Length; i++)
			{
				Array.Resize(ref secondPartArr, secondPartArr.Length + 1);
				secondPartArr[secondPartArr.Length - 1] = arr[i];
			}
			int[] firstPartArr = new int[0];
			for (int i = 0; i < arr.Length / 2; i++)
			{
				Array.Resize(ref firstPartArr, firstPartArr.Length + 1);
				firstPartArr[firstPartArr.Length - 1] = arr[i];
			}
			return MergeArrays(Sort(firstPartArr), Sort(secondPartArr));
		}

		private static int[] MergeArrays(int[] arr1, int[] arr2)
		{
			int ii = 0, jj = 0;
			int[] mergedArr = new int[arr1.Length + arr2.Length];
			for (int i = 0; i < mergedArr.Length; i++)
			{
				if (ii < arr1.Length && jj < arr2.Length)
				{
					if (arr1[ii] > arr2[jj])
					{
						mergedArr[i] = arr2[jj++];
					}
					else
					{
						mergedArr[i] = arr1[ii++];
					}
				}
				else
				{
					if (jj < arr2.Length)
					{
						mergedArr[i] = arr2[jj++];
					}
					else
					{
						mergedArr[i] = arr1[ii++];
					}
				}
			}
			return mergedArr;
		}
	}
}
