using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
	public class SquareMatrix<T> : BaseMatrix<T>
	{
		public T[] elems;

        public override T[,] Matrix
        {
            get
            {
                T[,] matrix = new T[size, size];
                int k = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = elems[k];
                        k++;
                    }
                }
                return matrix;
            }
            set
            {

            }
        }

		public new  T this[int i, int j]
		{
			get
			{
				return Matrix[i, j];
			}
			set
			{
				changeAction();
				Matrix[i, j] = value;
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

		public SquareMatrix(int size, params T[] matrixElements)
		{
			this.size = size;
            elems = matrixElements;
		}
	}
}
