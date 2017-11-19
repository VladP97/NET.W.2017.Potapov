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
			DiagonalMatrix<int> dm = new DiagonalMatrix<int>(3, 6, 2, 1);
			for (int i = 0; i < dm.Size; i++)
			{
				for (int j = 0; j < dm.Size; j++)
				{
					Console.Write(dm.matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		[TestMethod()]
		public void SquareMatrixTest()
		{
			Console.WriteLine();
			SquareMatrix<int> sm = new SquareMatrix<int>(3, 1, 2, 3, 4, 5, 6, 7, 8, 9);
			for (int i = 0; i < sm.Size; i++)
			{
				for (int j = 0; j < sm.Size; j++)
				{
					Console.Write(sm.matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		[TestMethod()]
		public void SymmetricMatrixTest()
		{
			SymmetricMatrix<int> sm1 = new SymmetricMatrix<int>(4, 3, 1, 2, 5, 11, 12, 13, 14, 15, 16);
			for (int i = 0; i < sm1.Size; i++)
			{
				for (int j = 0; j < sm1.Size; j++)
				{
					Console.Write(sm1.matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
		}


	}
}