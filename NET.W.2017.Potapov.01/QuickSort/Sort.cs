using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
	public static class Sort
	{
		private static void Swap(ref int el1, ref int el2)
		{
			int copiedEl = el1;
			el1 = el2;
			el2 = copiedEl;
		}

		public static void QuickSort(int[] arr)
		{
			int first = 0;
			int last = arr.Length - 1;
			int begin = 0;
			int end = arr.Length - 1;
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
				QuickSort(arr, first, end);
			}
			if (last > begin)
			{
				QuickSort(arr, begin, last);
			}
		}

		public static void QuickSort(int[] arr, int first, int last)
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
				QuickSort(arr, first, end);
			}
			if (last > begin)
			{
				QuickSort(arr, begin, last);
			}
		}

		public static void MergeSort(int[] arr)
		{
			int[] sortedArray = SeparateArray(arr);
			for (int i = 0; i < sortedArray.Length; i++)
			{
				arr[i] = sortedArray[i];
			}
		}

		public static int[] SeparateArray(int[] arr)
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

			return MergeArrays(SeparateArray(firstPartArr), SeparateArray(secondPartArr));
		}

		private static int[] MergeArrays(int[] arr1, int[] arr2)
		{
			int j = 0, k = 0;
			int[] mergedArr = new int[arr1.Length + arr2.Length];
			for (int i = 0; i < mergedArr.Length; i++)
			{
				if (j < arr1.Length && k < arr2.Length)
				{
					if (arr1[j] > arr2[k])
					{
						mergedArr[i] = arr2[k++];
					}
					else
					{
						mergedArr[i] = arr1[j++];
					}
				}
				else
				{
					if (k < arr2.Length)
					{
						mergedArr[i] = arr2[k++];
					}
					else
					{
						mergedArr[i] = arr1[j++];
					}
				}
			}
			return mergedArr;
		}
	}
}
