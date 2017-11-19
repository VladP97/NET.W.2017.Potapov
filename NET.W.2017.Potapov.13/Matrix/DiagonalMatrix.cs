using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
	public class DiagonalMatrix<T> : IMatrix<T>
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

		public DiagonalMatrix(int size, params T[] matrixElements)
		{
			this.size = size;
			matrix = new T[size, size];
			if (size == matrixElements.Length)
			{
				for (int i = 0; i < size; i++)
				{
					matrix[i, i] = matrixElements[i];
				}
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}
}
