using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Tests
{
	[TestClass()]
	public class DiagonalMatrixTests
	{
		[TestMethod()]
		public void DiagonalMatrixTest()
		{
			DiagonalMatrix<int> dm1 = new DiagonalMatrix<int>(3, 6, 2, 1);
            DiagonalMatrix<int> dm2 = new DiagonalMatrix<int>(3, 6, 2, 1);
            BaseMatrix<int> dm3 = dm1.Add(dm2);
            int[,] matrix = dm3.Matrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}


		}

        [TestMethod()]
        public void SquareMatrixTest()
        {
            int[] elems = new int[] { 1, 2, 3 };
            SymmetricMatrix<int> sm1 = new SymmetricMatrix<int>(elems, 4, 5, 6);

            SymmetricMatrix<int> sm2 = new SymmetricMatrix<int>(elems, 7, 8, 9);
            BaseMatrix<int> sm3 = sm1.Add(sm2);
            int[,] matrix = sm3.Matrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //[TestMethod()]
        //public void SymmetricMatrixTest()
        //{
        //	SymmetricMatrix<int> sm1 = new SymmetricMatrix<int>(4, 3, 1, 2, 5, 11, 12, 13, 14, 15, 16);
        //	for (int i = 0; i < sm1.Size; i++)
        //	{
        //		for (int j = 0; j < sm1.Size; j++)
        //		{
        //			Console.Write(sm1.matrix[i, j] + " ");
        //		}
        //		Console.WriteLine();
        //	}
        //}


    }
}