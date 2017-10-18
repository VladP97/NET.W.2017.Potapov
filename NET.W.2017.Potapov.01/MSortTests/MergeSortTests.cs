using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSort.Tests
{
	[TestClass()]
	public class MergeSortTests
	{
		[TestMethod()]
		public void SortTest()
		{
			int[] arr = new int[] { 3, 4, 6, 12, 54, 5, 4, 2 };
			int[] arrangeArr = new int[] { 2, 3, 4, 4, 5, 6, 12, 54 };

			int[] actArray = MergeSort.Sort(arr);

			CollectionAssert.AreEqual(arrangeArr, actArray);
		}
	}
}