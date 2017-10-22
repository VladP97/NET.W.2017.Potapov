using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryShift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShift.Tests
{
	[TestClass()]
	public class BinaryNumberShiftTests
	{
		[TestMethod()]
		public void InsertNumber_15and15and0and0_15result()
		{
			int testValue = 0;

			testValue = BinaryNumberShift.InsertNumber(15, 15, 0, 0);

			Assert.AreEqual(15, testValue);
		}

		[TestMethod()]
		public void InsertNumber_8and15and0and0_9result()
		{
			int testValue = 0;

			testValue = BinaryNumberShift.InsertNumber(8, 15, 0, 0);

			Assert.AreEqual(9, testValue);
		}

		[TestMethod()]
		public void InsertNumber_8and15and3and8_120result()
		{
			int testValue = 0;

			testValue = BinaryNumberShift.InsertNumber(8, 15, 3, 8);

			Assert.AreEqual(120, testValue);
		}
	}
}