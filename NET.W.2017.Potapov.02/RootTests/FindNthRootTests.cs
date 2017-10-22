using Microsoft.VisualStudio.TestTools.UnitTesting;
using Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Tests
{
	[TestClass()]
	public class FindNthRootTests
	{
		[TestMethod()]
		public void FindRootTest_1and5and0001_1result()
		{
			double testValue = 0;

			testValue = FindNthRoot.FindRoot(1, 5, 0.0001);

			Assert.AreEqual(1, testValue);
		}

		[TestMethod()]
		public void FindRootTest_8and3and0001_2result()
		{
			double testValue = 0;

			testValue = FindNthRoot.FindRoot(8,3,0.0001);

			Assert.AreEqual(2, testValue);
		}

		[TestMethod()]
		public void FindRootTest_004100625and4and0001_045result()
		{
			double testValue = 0;

			testValue = FindNthRoot.FindRoot(0.04100625, 4, 0.0001);

			Assert.AreEqual(0.45, testValue);
		}

		[TestMethod()]
		public void FindRootTest_00279936and7and0001_06result()
		{
			double testValue = 0;

			testValue = FindNthRoot.FindRoot(0.0279936, 7, 0.0001);

			Assert.AreEqual(0.6, testValue);
		}

		[TestMethod()]
		public void FindRootTest_00081and4and01_03result()
		{
			double testValue = 0;

			testValue = FindNthRoot.FindRoot(0.0081, 4, 0.1);

			Assert.AreEqual(0.3, testValue);
		}

		[TestMethod()]
		public void FindRootTest_Negative0008and3and01_Negative02result()
		{
			double testValue = 0;

			testValue = FindNthRoot.FindRoot(-0.008, 3, 0.1);

			Assert.AreEqual(-0.2, testValue);
		}

		[TestMethod()]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void FindRootTest_Negative16and4and0001_06result()
		{
			double testValue = 0;

			testValue = FindNthRoot.FindRoot(-16, 4, 0.0001);

		}
	}
}