using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShift
{
	public static class BinaryNumberShift
	{
		private static string insertBits(this string numberToInsert)
		{
			string str = new string('0', 31 - numberToInsert.Length);
			return str + numberToInsert;
		}

		public static int InsertNumber(int numberSource, int numberToInsert, int shift, int shiftTo)
		{
			string binNumberSource = Convert.ToString(numberSource, 2);
			string binNumberToInsert = Convert.ToString(numberToInsert, 2);
			char[] binNumberSourceCharArray = binNumberSource.insertBits().ToCharArray();
			char[] binNumberToInsertCharArray = binNumberToInsert.insertBits().ToCharArray();
			Array.Reverse(binNumberSourceCharArray);
			Array.Reverse(binNumberToInsertCharArray);
			int j = shift;
			for (int i = 0; i <= shiftTo - shift; i++)
			{
				if (binNumberSourceCharArray[j] == '1' || binNumberToInsertCharArray[i] == '1')
				{
					binNumberSourceCharArray[j] = '1';
				}
				else if (binNumberSourceCharArray[j] == '0' && binNumberToInsertCharArray[i] == '0')
				{
					binNumberSourceCharArray[j] = '0';
				}
				j++;
			}
			foreach (var item in binNumberSourceCharArray)
			{
				Console.WriteLine(item);
			}
			Array.Reverse(binNumberSourceCharArray);
			int deleteTo = 31 - Array.IndexOf(binNumberSourceCharArray, '1');
			Array.Reverse(binNumberSourceCharArray);
			Array.Resize(ref binNumberSourceCharArray, deleteTo);
			Array.Reverse(binNumberSourceCharArray);
			return Convert.ToInt32(new string(binNumberSourceCharArray), 2);
		}
	}
}
