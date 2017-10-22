using System;
using FilterDigit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilterDigitTests
{
	[TestClass]
	public class FilterDigitTests
	{
		[TestMethod]
		public void FilterDigitTest_11and12and23and34and12and31_11and12and12and31result()
		{
			int digit = 1;

			int[] arrangeValue = digit.FilterDigit(11, 12, 23, 34, 12, 31);
			int[] expectedValue = new[] {11, 12, 12, 31};

			CollectionAssert.AreEqual(expectedValue, arrangeValue);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void FilterDigitTest_LessThenZero_ExeptionResult()
		{
			int digit = -1;

			int[] arrangeValue = digit.FilterDigit(11, 12, 23, 34, 12, 31);
			int[] expectedValue = new[] { 11, 12, 12, 31 };
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void FilterDigitTest_MoreThen9_ExeptionResult()
		{
			int digit = 10;

			int[] arrangeValue = digit.FilterDigit(11, 12, 23, 34, 12, 31);
			int[] expectedValue = new[] { 11, 12, 12, 31 };
		}
	}
}
