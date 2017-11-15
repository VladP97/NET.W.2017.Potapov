using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class Fibonacci
    {
		public static int[] GetFibonacciSequence(int number)
		{
			int prevNumb = 1;
			int result = 1;
			int[] fibonnachiArray = new int[number];
			for (int i = 0; i < number; i++)
			{
				result = result + prevNumb;
				fibonnachiArray[i] = result;
				prevNumb = result - prevNumb;
			}
			return fibonnachiArray;
		}
	}
}
