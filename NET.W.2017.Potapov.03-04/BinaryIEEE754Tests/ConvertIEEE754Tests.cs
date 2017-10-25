using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryIEEE754;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryIEEE754.Tests
{
	[TestClass()]
	public class ConvertIEEE754Tests
	{
		[TestMethod()]
		public void toBinaryIEEE754Test_Negative255_255()
		{
			double number = -255.255;

			string result = number.ToBinaryIEEE754();

			Assert.AreEqual("1100000001101111111010000010100011110101110000101000111101011100", result);
		}

		[TestMethod()]
		public void toBinaryIEEE754Test_255_255()
		{
			double number = 255.255;

			string result = number.ToBinaryIEEE754();

			Assert.AreEqual("0100000001101111111010000010100011110101110000101000111101011100", result);
		}

		[TestMethod()]
		public void toBinaryIEEE754Test_4294967295_0()
		{
			double number = 4294967295.0;

			string result = number.ToBinaryIEEE754();

			Assert.AreEqual("0100000111101111111111111111111111111111111000000000000000000000", result);
		}

		[TestMethod()]
		public void toBinaryIEEE754Test_DoubleMinValue()
		{
			double number = double.MinValue;
			Console.WriteLine(number / 307);


			string result = number.ToBinaryIEEE754();

			Assert.AreEqual("1111111111101111111111111111111111111111111111111111111111111111", result);
		}
	}
}