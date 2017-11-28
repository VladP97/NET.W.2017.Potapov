using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public static class Sequence<T>
    {
        public static T[] GetSequnce(int count, IAlgorithm<T> algorithm)
        {
            dynamic prevNumb = 1;
            dynamic curNumb = 2;
            dynamic result;
            T[] array = new T[count];
            array[0] = prevNumb;
            array[1] = curNumb;
            for (int i = 2; i < count; i++)
            {
                result = algorithm.GetNumber(prevNumb, curNumb);
                array[i] = result;
                prevNumb = curNumb;
                curNumb = result;
            }
            return array;
        }
    }
}
