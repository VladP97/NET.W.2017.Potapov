using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindNextBiggerNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumber.Tests
{
	[TestClass()]
	public class NumberTests
	{
		[TestMethod()]
		public void FindNextBiggerNumberTest12()
		{
			int testValue = 12;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();

			Assert.AreEqual(21, fact);
		}

		[TestMethod()]
		public void FindNextBiggerNumberTest513()
		{
			int testValue = 513;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();

			Assert.AreEqual(531, fact);
		}

		[TestMethod()]
		public void FindNextBiggerNumberTest2017()
		{
			int testValue = 2017;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();

			Assert.AreEqual(2071, fact);
		}

		[TestMethod()]
		public void FindNextBiggerNumberTest414()
		{
			int testValue = 414;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();

			Assert.AreEqual(441, fact);
		}

		[TestMethod()]
		public void FindNextBiggerNumberTest144()
		{
			int testValue = 144;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();

			Assert.AreEqual(414, fact);
		}

		[TestMethod()]
		public void FindNextBiggerNumberTest1234321()
		{
			int testValue = 1234321;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();

			Assert.AreEqual(1241233, fact);
		}

		[TestMethod()]
		public void FindNextBiggerNumberTest1234126()
		{
			int testValue = 1234126;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();

			Assert.AreEqual(1234162, fact);
		}

		[TestMethod()]
		public void FindNextBiggerNumberTest3456432()
		{
			int testValue = 3456432;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();
			Console.WriteLine(timeElapsed);
			
			Assert.AreEqual(3462345, fact);
		}

		[TestMethod()]
		public void FindNextBiggerNumberTest10()
		{
			int testValue = 10;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();

			Assert.AreEqual(-1, fact);
		}

		[TestMethod()]
		public void FindNextBiggerNumberTest20()
		{
			int testValue = 20;

			(int fact, long timeElapsed) = testValue.FindNextBiggerNumber();

			Assert.AreEqual(-1, fact);
		}
	}
}