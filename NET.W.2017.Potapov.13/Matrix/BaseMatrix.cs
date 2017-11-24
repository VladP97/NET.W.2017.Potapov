using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public abstract class BaseMatrix<T> : IMatrixAddition<T>
    {
        protected int size;

        public int Size
		{
			get { return size; }
		}

        public virtual T[,] Matrix
		{
			get;
            set;
		}

        public T this[int i, int j]
		{
			get { return Matrix[i, j]; }
			set { Matrix[i, j] = value; }
		}

        public BaseMatrix<T> Add(BaseMatrix<T> matrix)
        {
            dynamic firstMatrix = matrix.Matrix;
            dynamic secondMatrix = Matrix;
            if (matrix.Size != Size)
            {
                throw new ArgumentException();
            }
            if (matrix.GetType() == typeof(DiagonalMatrix<T>) && GetType() == typeof(DiagonalMatrix<T>))
            {
                T[] diagonal = new T[matrix.size];
                for (int i = 0; i < diagonal.Length; i++)
                {
                    diagonal[i] = firstMatrix[i, i] + secondMatrix[i, i];       
                }
                return new DiagonalMatrix<T>(diagonal);
            }
            if (matrix.GetType() == typeof(SymmetricMatrix<T>) && GetType() == typeof(SymmetricMatrix<T>))
            {
                T[] diagonal = new T[matrix.size];
                int elementsLength = (matrix.Size * matrix.Size - matrix.Size) / 2;
                T[] elements = new T[elementsLength];
                for (int i = 0; i < diagonal.Length; i++)
                {
                    diagonal[i] = firstMatrix[i, i] + secondMatrix[i, i];
                }
                int k = 0;
                try
                {
                    for (int i = 1; i < matrix.Size; i++)
                    {
                        for (int j = i; j < matrix.Size; j++)
                        {
                            elements[k] = firstMatrix[i - 1, j] + secondMatrix[i - 1, j];
                            k++;
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    return new SymmetricMatrix<T>(elements, diagonal);
                }
                return new SymmetricMatrix<T>(elements, diagonal);
            }
            else
            {
                T[] elements = new T[matrix.size * matrix.size];
                for (int i = 0; i < matrix.Size; i++)
                {
                    for (int j = 0; j < matrix.Size; j++)
                    {

                    }
                }
                return new SquareMatrix<T>(matrix.Size, elements);
            }
        }

		Action ChangeAction { get; set; }
    }
}
