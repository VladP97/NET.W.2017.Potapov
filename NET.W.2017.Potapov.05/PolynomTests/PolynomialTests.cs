using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polynom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynom.Tests
{
	[TestClass()]
	public class PolynomialTests
	{
		[TestMethod()]
		public void PolynomialTest_1and2and3()
		{
			Polynomial ex = new Polynomial(1, 2, 3);

			string result = ex.ToString();

			Assert.AreEqual("1 + 2x^1 + 3x^2", result);
		}

		[TestMethod()]
		public void PolynomialTest_Calculate1and2and3()
		{
			Polynomial ex = new Polynomial(1, 2, 3);

			double result = ex.Calculate(2);

			Assert.AreEqual(17, result);
		}

		[TestMethod()]
		public void PolynomialTest_PlusOperator()
		{
			Polynomial ex1 = new Polynomial(1, 2, 3);
			Polynomial ex2 = new Polynomial(1, 2, 3, 4);
			Polynomial result;

			result = ex1 + ex2;

			Assert.AreEqual("2 + 4x^1 + 6x^2 + 4x^3", result.ToString());
		}

		[TestMethod()]
		public void PolynomialTest_MinusOperator()
		{
			Polynomial ex1 = new Polynomial(2, 5, 3);
			Polynomial ex2 = new Polynomial(1, -2, 3, 4);
			Polynomial result;

			result = ex1 - ex2;

			Assert.AreEqual("1 + 7x^1 + 0x^2 + -4x^3", result.ToString());
		}

		[TestMethod()]
		public void PolynomialTest_СompositionOperator()
		{
			Polynomial ex1 = new Polynomial(1, 2, 3);
			Polynomial ex2 = new Polynomial(1, 2, 3, 4);
			Polynomial result;

			result = ex1 * ex2;

			Assert.AreEqual("1 + 4x^1 + 9x^2 + 4x^3", result.ToString());
		}

		[TestMethod()]
		public void PolynomialTest_EqualsOperator()
		{
			Polynomial ex1 = new Polynomial(1, 2, 3);
			Polynomial ex2 = new Polynomial(1, 2, 3);
			bool result;

			result = ex1 == ex2;

			Assert.AreEqual(true, result);
		}

		[TestMethod()]
		public void PolynomialTest_UnequalOperator()
		{
			Polynomial ex1 = new Polynomial(1, 2, 3);
			Polynomial ex2 = new Polynomial(1, 2, 3);
			bool result;

			result = ex1 != ex2;

			Assert.AreEqual(false, result);
		}
	}
}