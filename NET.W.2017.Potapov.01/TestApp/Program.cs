using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QSort;
using MSort;

namespace TestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] {3, 4, 6, 12, 54, 5, 4, 2};
			int[] sortedArray = QuickSort.Sort(arr, 0, arr.Length - 1);
			
			foreach (var item in sortedArray)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}
