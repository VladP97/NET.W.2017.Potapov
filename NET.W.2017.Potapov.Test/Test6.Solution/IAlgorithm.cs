using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public interface IAlgorithm<T>
    {
        T GetNumber(T first, T second);
    }
}
