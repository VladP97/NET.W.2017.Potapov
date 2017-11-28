using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public class Calculator<T>
    {
        List<ICalculate<T>> calculateAlgorithms =  new List<ICalculate<T>>();

        public void Add(ICalculate<T> method)
        {
            calculateAlgorithms.Add(method);
        }

        public ICalculate<T> this[int index]
        {
            get { return calculateAlgorithms[index]; }
        }
    }
}
