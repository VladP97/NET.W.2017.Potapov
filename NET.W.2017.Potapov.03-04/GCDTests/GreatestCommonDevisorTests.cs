using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD.Tests
{
	[TestClass()]
	public class GreatestCommonDevisorTests
	{
		[TestMethod()]
		public void FindGDCbyEuclideanAlgorithmTest_12and9and6_3result()
		{
			int a = 12, b = 9, c = 6;

			int gdc = GreatestCommonDevisor.FindGDCbyEuclideanAlgorithm(a, b, c);

			Assert.AreEqual(3, gdc);
		}

		[TestMethod()]
		public void FindGDCbyEuclideanAlgorithmTest_12and9_3result()
		{
			int a = 12, b = 9;

			int gdc = GreatestCommonDevisor.FindGDCbyEuclideanAlgorithm(a, b);

			Assert.AreEqual(3, gdc);
		}

		[TestMethod()]
		public void FindGDCbyEuclideanAlgorithmTest_12_12result()
		{
			int a = 12;

			int gdc = GreatestCommonDevisor.FindGDCbyEuclideanAlgorithm(a);

			Assert.AreEqual(12, gdc);
		}

		[TestMethod()]
		[ExpectedException(typeof(NullReferenceException))]
		public void FindGDCbyEuclideanAlgorithmTest_null_NullReferenceExeption()
		{
			int gdc = GreatestCommonDevisor.FindGDCbyEuclideanAlgorithm();
		}

		[TestMethod()]
		public void FindGDCbyEuclideanAlgorithmTest_12and12and12_12result()
		{
			int a = 12, b = 12, c = 12;

			int gdc = GreatestCommonDevisor.FindGDCbyEuclideanAlgorithm(a, b, c);

			Assert.AreEqual(12, gdc);
		}

		[TestMethod()]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void FindGDCbyEuclideanAlgorithmTest_Negative9and3and6_ArgumentOutOfRangeException()
		{
			int a = -9, b = -3, c = -6;

			int gdc = GreatestCommonDevisor.FindGDCbyEuclideanAlgorithm(a, b, c);
		}

		[TestMethod()]
		public void FindGDCSteinsAlgorithmTest_12and9and6_3result()
		{
			int a = 12, b = 9, c = 6;

			int gdc = GreatestCommonDevisor.FindGDCbySteinsAlgorithm(a, b, c);

			Assert.AreEqual(3, gdc);
		}

		[TestMethod()]
		public void FindGDCbySteinsAlgorithmTest_12and9_3result()
		{
			int a = 12, b = 9;

			int gdc = GreatestCommonDevisor.FindGDCbySteinsAlgorithm(a, b);
			Console.WriteLine();

			Assert.AreEqual(3, gdc);
		}

		[TestMethod()]
		public void FindGDCbySteinsAlgorithmTest_12_12result()
		{
			int a = 12;

			int gdc = GreatestCommonDevisor.FindGDCbySteinsAlgorithm(a);

			Assert.AreEqual(12, gdc);
		}

		[TestMethod()]
		[ExpectedException(typeof(NullReferenceException))]
		public void FindGDCbySteinsAlgorithmTest_null_NullReferenceExeption()
		{
			int gdc = GreatestCommonDevisor.FindGDCbySteinsAlgorithm();
		}

		[TestMethod()]
		public void FindGDCbySteinsAlgorithmTest_12and12and12_12result()
		{
			int a = 12, b = 12, c = 12;

			int gdc = GreatestCommonDevisor.FindGDCbySteinsAlgorithm(a, b, c);

			Assert.AreEqual(12, gdc);
		}

		[TestMethod()]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void FindGDCbySteinsAlgorithmTest_Negative9and3and6_ArgumentOutOfRangeException()
		{
			int a = -9, b = -3, c = -6;

			int gdc = GreatestCommonDevisor.FindGDCbySteinsAlgorithm(a, b, c);
		}
	}
}