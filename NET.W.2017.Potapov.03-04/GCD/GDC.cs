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
		#region
		public static int FindGDCbyEuclideanAlgorithm(params int[] numbers)
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
				gdc = EuclideanAlgorithm(numbers[0], numbers[1]);
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
				gdc = EuclideanAlgorithm(gdc, numbers[i]);
			}
			return gdc;
		}
		#endregion

		#region
		private static int EuclideanAlgorithm(int a, int b)
		{
			while (a != b)
			{
				if (a > b)
				{
					a = a - b;
				}
				else
				{
					b = b - a;
				}
			}
			return a;
		}
		#endregion

		#region
		public static int FindGDCbySteinsAlgorithm(params int[] numbers)
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
				gdc = StainsAlgorithm(numbers[0], numbers[1]);
				Console.WriteLine(gdc);
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
				gdc = StainsAlgorithm(gdc, numbers[i]);
			}
			return gdc;
		}
		#endregion

		#region
		private static int StainsAlgorithm(int a, int b)
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
				return 2 * StainsAlgorithm(a >> 1, b >> 1);
			}
			if (a % 2 == 0)
			{
				return StainsAlgorithm(a >> 1, b);
			}
			if (b % 2 == 0)
			{
				return StainsAlgorithm(a, b >> 1);
			}
			if (a > b)
			{
				return StainsAlgorithm((a - b) >> 1, a);
			}
			if (a < b)
			{
				return StainsAlgorithm((b - a) >> 1, a);
			}
			return StainsAlgorithm(a, b);
		}
		#endregion
	}
}
