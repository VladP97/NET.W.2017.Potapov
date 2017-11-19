using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
	public class SymmetricMatrix<T> : IMatrix<T>
	{
		protected int size;
		public T[,] matrix;

		public int Size
		{
			get { return size; }
		}

		public T[,] Matrix
		{
			get { return matrix; }
		}

		public T this[int i, int j]
		{
			get
			{
				return matrix[i, j];
			}
			set
			{
				changeAction();
				matrix[i, j] = value;
			}
		}

		public Action ChangeAction
		{
			get { return changeAction; }
			set { changeAction = value; }
		}

		Action changeAction = delegate ()
		{
			Console.WriteLine("Value in matrix was changed.");
		};

		public SymmetricMatrix(int size, params T[] matrixElements)
		{
			this.size = size;
			matrix = new T[size,size];
			if (size * size < matrixElements.Length)
			{
				throw new ArgumentException();
			}
			else
			{
				for (int i = 0; i < size; i++)
				{
					matrix[i,i] = matrixElements[i];
				}
				int k = size;
				try
				{
					for (int i = 0; i < size; i++)
					{
						for (int j = i; j < size; j++)
						{
							if (i != j)
							{
								matrix[i,j] = matrixElements[k];
								matrix[j,i] = matrixElements[k];
								k++;
							}
						}
					}
				}
				catch (IndexOutOfRangeException)
				{
					return;
				}
			}
		}
	}
}
