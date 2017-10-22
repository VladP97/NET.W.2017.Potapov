using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryShift;
using NUnit.Framework;

namespace BinaryShiftTests
{
	[TestFixture]
    public class BinaryNumberShiftTests
    {
		[TestCase(15, 15, 0, 0, 15)]
		[TestCase(8, 15, 0, 0, 9)]
		[TestCase(8, 15, 3, 8, 120)]
		public void InsertNumber(int numberSource, int numberToInsert, int shift, int shiftTo, int ExpectedResult)
		{
			int testValue = 0;

			testValue = BinaryNumberShift.InsertNumber(numberSource, numberToInsert, shift, shiftTo);

			Assert.AreEqual(ExpectedResult, testValue);
		}
	}
}
