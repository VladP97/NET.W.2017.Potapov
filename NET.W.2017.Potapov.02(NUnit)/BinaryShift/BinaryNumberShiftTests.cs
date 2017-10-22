using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumber.Tests
{
	[TestClass()]
	public class BinaryNumberShiftTests
	{
		[TestMethod()]
		public void BinaryOrMSTest()
		{
			int testValue = 0;

			testValue = BinaryNumberShift.InsertNumber(8, 15, 3, 8);

			Assert.AreEqual(120, testValue);
		}
	}
}