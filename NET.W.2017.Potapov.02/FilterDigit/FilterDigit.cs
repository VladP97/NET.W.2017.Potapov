using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigit
{
    public static class Filter
	{
		public static int[] FilterDigit(this int number, params int[] digitSequence)
		{
			if (number < 0 || number > 9)
			{
				throw new ArgumentOutOfRangeException();
			}
			string stringNumber = number.ToString();
			int[] result = new int[digitSequence.Length];
			int k = 0;
			for (int i = 0; i < digitSequence.Length; i++)
			{
				char[] digitSequenceChar = digitSequence[i].ToString().ToCharArray();
				for (int j = 0; j < digitSequenceChar.Length; j++)
				{
					if (char.Parse(number.ToString()) == digitSequenceChar[j])
					{
						result[k] = digitSequence[i];
						k++;
						break;
					}
				}
			}
			Array.Resize(ref result, k);
			return result;
		}
    }
}
