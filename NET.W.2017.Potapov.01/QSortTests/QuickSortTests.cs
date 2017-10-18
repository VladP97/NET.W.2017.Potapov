using Microsoft.VisualStudio.TestTools.UnitTesting;
using QSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSort.Tests
{
	[TestClass()]
	public class QuickSortTests
	{
		[TestMethod()]
		public void SortTest()
		{
			int[] arr = new int[] { 3, 4, 6, 12, 54, 5, 4, 2 };
			int[] arrangeArr = new int[] { 2, 3, 4, 4, 5, 6, 12, 54 };

			int[] actArray = QuickSort.Sort(arr, 0, arr.Length - 1);

			CollectionAssert.AreEqual(arrangeArr, actArray);
		}
	}
}