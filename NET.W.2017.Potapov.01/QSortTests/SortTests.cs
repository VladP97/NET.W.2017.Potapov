using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Tests
{
	[TestClass()]
	public class SortTests
	{
		[TestMethod()]
		public void MergeSortTest()
		{
			int[] arr = new int[] { 3, 4, 6, 12, 54, 5, 4, 2 };
			int[] arrangeArr = new int[] { 2, 3, 4, 4, 5, 6, 12, 54 };

			Sort.MergeSort(arr);
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}

			CollectionAssert.AreEqual(arrangeArr, arr);
		}

		[TestMethod()]
		public void QuickSortTest()
		{
			int[] arr = new int[] { 3, 4, 6, 12, 54, 5, 4, 2 };
			int[] arrangeArr = new int[] { 2, 3, 4, 4, 5, 6, 12, 54 };

			Sort.QuickSort(arr);

			CollectionAssert.AreEqual(arrangeArr, arr);
		}
	}
}