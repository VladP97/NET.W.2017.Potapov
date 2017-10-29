using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public static class JaggedArray
	{
		public delegate bool Expression(int[] x, int[] y);

		/// <summary>
		/// Sorts jagged array by maximum sum of elements in inner arrays.
		/// </summary>
		/// <param name="array">Array to sort</param>
		public static void SortBySum(int[][] array)
		{
			Sort(array, (x, y) => x.Sum() > y.Sum());
		}

		/// <summary>
		/// Sorts jagged array by minimum sum of elements in inner arrays.
		/// </summary>
		/// <param name="array">Array to sort</param>
		public static void SortBySumDecrease(int[][] array)
		{
			Sort(array, (x, y) => x.Sum() < y.Sum());
		}

		/// <summary>
		/// Sorts jagged array by greatest element of inner arrays.
		/// </summary>
		/// <param name="array">Array to sort</param>
		public static void SortByMaxValue(int[][] array)
		{
			Sort(array, (x, y) => x.Max() > y.Max());
		}

		/// <summary>
		/// Sorts jagged array by greatest element of inner arrays by decrease.
		/// </summary>
		/// <param name="array">Array to sort</param>
		public static void SortByMaxValueDecrease(int[][] array)
		{
			Sort(array, (x, y) => x.Max() < y.Max());
		}

		/// <summary>
		/// Sorts jagged array by smallest element of inner arrays.
		/// </summary>
		/// <param name="array">Array to sort</param>
		public static void SortByMinValue(int[][] array)
		{
			Sort(array, (x, y) => x.Min() > y.Min());
		}

		/// <summary>
		/// Sorts jagged array by smallest element of inner arrays by decrease.
		/// </summary>
		/// <param name="array">Array to sort</param>
		public static void SortByMinValueDecrease(int[][] array)
		{
			Sort(array, (x, y) => x.Min() < y.Min());
		}

		public static void Sort(int[][] array, Expression exp)
		{
			if (array == null)
			{
				throw new NullReferenceException();
			}
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - 1 - i; j++)
				{
					if (exp(array[j], array[j + 1]))
					{
						Swap(ref array[j], ref array[j + 1]);
					}
				}
			}
		}

		private static void Swap(ref int[] array1, ref int[] array2)
		{
			int[] arrayCopy = array1;
			array1 = array2;
			array2 = arrayCopy;
		}
    }
}
