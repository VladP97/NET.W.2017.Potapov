using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace FindNextBiggerNumber
{
    public static class Number
	{
		private static void Swap(ref char firstStringChar, ref char secondStringChar)
		{
			char firstStringCharCopy = firstStringChar;
			firstStringChar = secondStringChar;
			secondStringChar = firstStringCharCopy;
		}

		private static List<int> Permutation(this int number, int index, int arrayLength, List<int> combinationsArray)
		{
			char[] stringNumber = number.ToString().ToCharArray();
			
			if (index == stringNumber.Length - 1)
			{
				combinationsArray.Add(int.Parse(new string(stringNumber)));
			}
			for (int i = index; i < stringNumber.Length; i++)
			{
				Swap(ref stringNumber[index], ref stringNumber[i]);
				Permutation(int.Parse(new string(stringNumber)), index + 1, stringNumber.Length - 1, combinationsArray);
				Swap(ref stringNumber[index], ref stringNumber[i]);
			}
			return combinationsArray;
		}

		public static (int, long) FindNextBiggerNumber(this int number)
		{
			Stopwatch timer = new Stopwatch();
			timer.Start();
			List<int> combinationsList = new List<int>();
			combinationsList = number.Permutation(0, number.ToString().ToCharArray().Length - 1, combinationsList);
			while (combinationsList.Min() <= number)
			{
				if (combinationsList.Count == 1)
				{
					timer.Stop();
					return (-1, timer.ElapsedMilliseconds);
				}
				combinationsList.Remove(combinationsList.Min());
			}
			timer.Stop();

			return (combinationsList.Min(), timer.ElapsedMilliseconds);
		}
	}
}
