using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    public static class GreatestCommonDevisor
    {
		delegate int GdcAlgorithm(int x);

		#region
		public static int FindGDCbyEuclideanAlgorithm(params int[] numbers)
		{
			GdcAlgorithm algorithm = new GdcAlgorithm((x) => x / 2);
			return ArgumentsCheck(algorithm, numbers);
		}
		#endregion

		#region
		public static int FindGDCbySteinsAlgorithm(params int[] numbers)
		{
			GdcAlgorithm algorithm = new GdcAlgorithm((x) => x >> 1);
			return ArgumentsCheck(algorithm, numbers);
		}
		#endregion

		#region
		private static int ArgumentsCheck(GdcAlgorithm algorithm, params int[] numbers)
		{
			if (numbers.Length == 0)
			{
				throw new NullReferenceException();
			}
			if (numbers.Length == 1)
			{
				return numbers[0];
			}
			int gdc = 0;
			if (numbers[0] > 0 && numbers[1] > 0)
			{
				gdc = FindGdc(numbers[0], numbers[1], algorithm);
			}
			else
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = 2; i < numbers.Length - 1; i++)
			{
				if (numbers[i] <= 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				gdc = FindGdc(gdc, numbers[i], algorithm);
			}
			return gdc;
		}
		#endregion

		private static int FindGdc(int a, int b, GdcAlgorithm algorithm)
		{
			if (a == 0)
			{
				return b;
			}
			if (b == 0)
			{
				return a;
			}
			if (a == b)
			{
				return a;
			}
			if (a % 2 == 0 && b % 2 == 0)
			{
				return 2 * FindGdc(algorithm(a), algorithm(b), algorithm);
			}
			if (a % 2 == 0)
			{
				return FindGdc(algorithm(a), b, algorithm);
			}
			if (b % 2 == 0)
			{
				return FindGdc(a, algorithm(b), algorithm);
			}
			if (a > b)
			{
				return FindGdc(algorithm(a - b), a, algorithm);
			}
			if (a < b)
			{
				return FindGdc(algorithm(b - a), a, algorithm);
			}
			return FindGdc(a, b, algorithm);
		}
	}
}
