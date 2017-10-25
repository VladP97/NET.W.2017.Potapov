using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryIEEE754
{
    public static class ConvertIEEE754
	{
		private static string GetFraction(string number)
		{
			double nextNumber = Convert.ToDouble("0," + number);
			int binaryNumber = 0;
			string binaryString = "";
			for (int i = 0; i < 52; i++)
			{
				nextNumber = nextNumber * 2;
				binaryNumber = Int32.Parse(nextNumber.ToString()[0].ToString());
				nextNumber -= binaryNumber;
				binaryString += binaryNumber;
			}
			return binaryString;
		}

		private static string ToBinary(this double number)
		{
			string result = "";
			while (number > 0)
			{
				result += number % 2;
				if (number % 2 == 1)
				{
					number--;
					number /= 2;
				}
				if (number % 2 == 0)
				{
					number /= 2;
				}
			}
			char[] charArray = result.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}

		private static string ToBinary(this int number)
		{
			string result = "";
			while (number > 0)
			{
				result += number % 2;
				number = number / 2;
			}
			char[] charArray = result.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}

		private static string To64(this string binaryNumber)
		{
			for (int i = binaryNumber.Length; i < 64; i++)
			{
				binaryNumber += "0";
			}
			return binaryNumber;
		}

		public static string ToBinaryIEEE754(this double number)
		{
			string binaryNumber = Convert.ToString(Math.Abs(number));
			string[] fractionStrings = binaryNumber.Split(',');
			string firstPart = Convert.ToDouble(fractionStrings[0]).ToBinary();
			string concatedString = "";
			if (fractionStrings.Length != 1)
			{
				concatedString = firstPart + GetFraction(fractionStrings[1]);
			} else
			{
				concatedString = firstPart;
			}
			int exp = firstPart.Length - 1;
			exp += 1023;
			string expBinary = exp.ToBinary();
			concatedString = concatedString.Remove(0, 1);
			string result;
			if (number < 0)
			{
				result = "1" + expBinary + concatedString;
			}
			else
			{
				result = "0" + expBinary + concatedString;
			}
			Console.WriteLine(result.Length);
			if (result.Length < 64)
			{
				return result.To64();
			}
			else
			{
				return result.Remove(64, result.Length - 64);
			}
		}
    }
}
