using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    interface IMatrixAddition<T>
    {
        BaseMatrix<T> Add(BaseMatrix<T> matrix);
    }
}
