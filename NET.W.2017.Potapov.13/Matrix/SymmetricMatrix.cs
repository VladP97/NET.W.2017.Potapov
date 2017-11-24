using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
	public class SymmetricMatrix<T> : DiagonalMatrix<T>
	{
		protected T[] elems;

		public override T[,] Matrix
		{
            get
            {
                T[,] matrix = base.Matrix;
                int k = 0;
                for (int i = 1; i < elems.Length; i++)
                {
                    for (int j = i; j < elems.Length; j++)
                    {
                        matrix[i - 1, j] = elems[k];
                        matrix[j, i - 1] = elems[k];
                        k++;
                    }
                }
                return matrix;
            }
        }

		public new T this[int i, int j]
		{
			get
			{
                return Matrix[i, j];
			}
			set
			{
				changeAction();
                if (i == j)
                {
                    diagonal[i] = value;
                }
                else
                {
                    elems[i + j - 1] = value;
                }
			}
		}

		Action changeAction = delegate ()
		{
			Console.WriteLine("Value in matrix was changed.");
		};

		public SymmetricMatrix(T[] elements, params T[] diagonal): base(diagonal)
		{
            if (elements.Length > ((diagonal.Length * diagonal.Length - diagonal.Length) / 2))
            {
                throw new ArgumentException();
            }
            elems = elements;
		}
	}
}
