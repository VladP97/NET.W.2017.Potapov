using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Tests
{
	[TestClass()]
	public class FibonacciTests
	{
		[TestMethod()]
		public void GetFibonacciSequenceTest()
		{
			int[] arr = Fibonacci.GetFibonacciSequence(6);

			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}
	}
}