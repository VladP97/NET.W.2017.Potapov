using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public interface IMatrix<T>
    {
		int Size
		{
			get;
		}

		T[,] Matrix
		{
			get;
		}

		T this[int i, int j]
		{
			get;
			set;
		}

		Action ChangeAction { get; set; }
    }
}
