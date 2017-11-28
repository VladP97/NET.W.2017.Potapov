using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public interface IGenerator<T>
    {
        T[] GetSequence(int array);
    }
}
