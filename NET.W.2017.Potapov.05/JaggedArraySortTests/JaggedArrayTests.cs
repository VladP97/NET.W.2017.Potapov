using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArraySort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort.Tests
{
	[TestClass()]
	public class JaggedArrayTests
	{
		[TestMethod()]
		public void JaggedArrayTest_SortBySumTest()
		{
			int[][] jaggedArray = new int[5][];
			jaggedArray[0] = new int[3] { 1, 5, 6 };
			jaggedArray[1] = new int[4] { 1, 5, 1, 7};
			jaggedArray[2] = new int[3] { 11, 25, 16 };
			jaggedArray[3] = new int[3] { 0, 0, 0 };
			jaggedArray[4] = new int[3] { 1, -5, 6 };

			JaggedArray.SortBySum(jaggedArray);

			for (int i = 0; i < jaggedArray.Length - 1; i++)
			{
				if (jaggedArray[i].Sum() > jaggedArray[i + 1].Sum())
				{
					Assert.Fail();
				}
			}
		}

		[TestMethod()]
		public void JaggedArrayTest_SortByMaxTest()
		{
			int[][] jaggedArray = new int[5][];
			jaggedArray[0] = new int[3] { 1, 5, 6 };
			jaggedArray[1] = new int[4] { 1, 5, 1, 7 };
			jaggedArray[2] = new int[3] { 11, 25, 16 };
			jaggedArray[3] = new int[3] { 0, 0, 0 };
			jaggedArray[4] = new int[3] { 1, 8, 6 };

			JaggedArray.SortByMaxValue(jaggedArray);

			for (int i = 0; i < jaggedArray.Length - 1; i++)
			{
				if (jaggedArray[i].Max() > jaggedArray[i + 1].Max())
				{
					Assert.Fail();
				}
			}
		}

		[TestMethod()]
		public void JaggedArrayTest_SortByMinTest()
		{
			int[][] jaggedArray = new int[5][];
			jaggedArray[0] = new int[3] { -1, 5, 6 };
			jaggedArray[1] = new int[4] { 1, -5, 1, 7 };
			jaggedArray[2] = new int[3] { 11, 25, 16 };
			jaggedArray[3] = new int[3] { 0, -4, 0 };
			jaggedArray[4] = new int[3] { 1, 8, 6 };

			JaggedArray.SortByMinValue(jaggedArray);

			for (int i = 0; i < jaggedArray.Length - 1; i++)
			{
				if (jaggedArray[i].Min() > jaggedArray[i + 1].Min())
				{
					Assert.Fail();
				}
			}
		}

		[TestMethod()]
		public void JaggedArrayTest_SortBySumDecreaseTest()
		{
			int[][] jaggedArray = new int[5][];
			jaggedArray[0] = new int[3] { 1, 5, 6 };
			jaggedArray[1] = new int[4] { 1, 5, 1, 7 };
			jaggedArray[2] = new int[3] { 11, 25, 16 };
			jaggedArray[3] = new int[3] { 0, 0, 0 };
			jaggedArray[4] = new int[3] { 1, -5, 6 };

			JaggedArray.SortBySumDecrease(jaggedArray);

			for (int i = 0; i < jaggedArray.Length - 1; i++)
			{
				if (jaggedArray[i].Sum() < jaggedArray[i + 1].Sum())
				{
					Assert.Fail();
				}
			}
		}

		[TestMethod()]
		public void JaggedArrayTest_SortByMaxDecreaseTest()
		{
			int[][] jaggedArray = new int[5][];
			jaggedArray[0] = new int[3] { 1, 5, 6 };
			jaggedArray[1] = new int[4] { 1, 5, 1, 7 };
			jaggedArray[2] = new int[3] { 11, 25, 16 };
			jaggedArray[3] = new int[3] { 0, 0, 0 };
			jaggedArray[4] = new int[3] { 1, 8, 6 };

			JaggedArray.SortByMaxValueDecrease(jaggedArray);

			for (int i = 0; i < jaggedArray.Length - 1; i++)
			{
				if (jaggedArray[i].Max() < jaggedArray[i + 1].Max())
				{
					Assert.Fail();
				}
			}
		}

		[TestMethod()]
		public void JaggedArrayTest_SortByMinDecreaseTest()
		{
			int[][] jaggedArray = new int[5][];
			jaggedArray[0] = new int[3] { -1, 5, 6 };
			jaggedArray[1] = new int[4] { 1, -5, 1, 7 };
			jaggedArray[2] = new int[3] { 11, 25, 16 };
			jaggedArray[3] = new int[3] { 0, -4, 0 };
			jaggedArray[4] = new int[3] { 1, 8, 6 };

			JaggedArray.SortByMinValueDecrease(jaggedArray);

			for (int i = 0; i < jaggedArray.Length - 1; i++)
			{
				if (jaggedArray[i].Min() < jaggedArray[i + 1].Min())
				{
					Assert.Fail();
				}
			}
		}

		[TestMethod()]
		[ExpectedException(typeof(NullReferenceException))]
		public void JaggedArrayTest_SortNull_ExeptionResult()
		{
			int[][] jaggedArray = null;

			JaggedArray.SortByMinValueDecrease(jaggedArray);
		}

		[TestMethod()]
		[ExpectedException(typeof(ArgumentNullException))]
		public void JaggedArrayTest_SortInnerArrayNull_ExeptionResult()
		{
			int[][] jaggedArray = new int[5][];
			jaggedArray[0] = new int[3] { -1, 5, 6 };
			jaggedArray[1] = null;
			jaggedArray[2] = new int[3] { 11, 25, 16 };
			jaggedArray[3] = new int[3] { 0, -4, 0 };
			jaggedArray[4] = new int[3] { 1, 8, 6 };

			JaggedArray.SortByMinValueDecrease(jaggedArray);
		}
	}
}