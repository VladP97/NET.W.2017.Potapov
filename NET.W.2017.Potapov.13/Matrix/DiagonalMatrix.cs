using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
	public class DiagonalMatrix<T> : BaseMatrix<T>
	{
		
		protected T[] diagonal;

		public override T[,] Matrix
		{
			get
            {
                T[,] matrix = new T[size, size];
                for (int i = 0; i < size; i++)
                {
                    matrix[i, i] = diagonal[i];
                }
                return matrix;
            }
		}

		public new T this[int i, int j]
		{
			get
			{
                if (i != j)
                {
                    return default(T);
                }
				return Matrix[i, j];
			}
            set
            {
                if (i == j)
                {
                    diagonal[i] = value;
                }
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

		public DiagonalMatrix(params T[] diagonal)
		{
			size = diagonal.Length;
            this.diagonal = diagonal;
		}
    }
}
