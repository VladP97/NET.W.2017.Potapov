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
		/// Sorts array by Linq expression.
		/// </summary>
		/// <param name="array">Array to sort.</param>
		/// <param name="exp">Sorting criteria.</param>
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
					if (array[j] == null || array[j + 1] == null)
					{
						throw new NullReferenceException();
					}
					if (exp(array[j], array[j + 1]))
					{
						Swap(ref array[j], ref array[j + 1]);
					}
				}
			}
		}

		/// <summary>
		/// Sorts array by IComparer expression.
		/// </summary>
		/// <param name="array">Array to sort.</param>
		/// <param name="exp">IComparer object.</param>
		public static void Sort(int[][] array, IComparer<int[]> exp)
		{
			if (array == null)
			{
				throw new NullReferenceException();
			}
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - 1 - i; j++)
				{
					if (array[j] == null || array[j + 1] == null)
					{
						throw new NullReferenceException();
					}
					if (0 < exp.Compare(array[j], array[j + 1]))
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
