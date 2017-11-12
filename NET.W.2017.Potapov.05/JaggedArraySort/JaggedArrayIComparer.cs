using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
	public class JaggedArrayIComparer: IComparer<int[]>
	{
		public delegate int Expression(int[] x, int[] y);
		private Expression expression;

		private JaggedArrayIComparer(Expression expression)
		{
			this.expression = expression;
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

		/// <summary>
		/// Sorts array by Linq expression.
		/// </summary>
		/// <param name="array">Array to sort.</param>
		/// <param name="exp">Sorting criteria.</param>
		public static void Sort(int[][] array, Expression exp)
		{
			Sort(array, new JaggedArrayIComparer(exp));
		}

		public int Compare(int[] obj1, int[] obj2)
		{
			return expression(obj1, obj2);
		}

		private static void Swap(ref int[] array1, ref int[] array2)
		{
			int[] arrayCopy = array1;
			array1 = array2;
			array2 = arrayCopy;
		}
	}
}
