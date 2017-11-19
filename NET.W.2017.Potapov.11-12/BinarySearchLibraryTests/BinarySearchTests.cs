using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchLibrary.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void SearchTest_array_1result()
        {
            int[] array = new int[5] { 1, 2, 5, 6, 8 };

            int index = BinarySearch<int>.Search(array, 2);

            Assert.AreEqual(1, index);
        }

        [TestMethod()]
        public void SearchTest_arrayInexistentValue_1result()
        {
            int[] array = new int[4] { 1, 5, 6, 8 };

            int index = BinarySearch<int>.Search(array, 2);

            Assert.AreEqual(-1, index);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
		public void SearchTest_unsortedArray_1result()
		{
			int[] array = new int[5] { 2, 1, 5, 8, 6 };

			int index = BinarySearch<int>.Search(array, 2);
		}

		[TestMethod()]
		public void SearchTest_doubleArray_2result()
		{
			double[] array = new double[5] { 1.1, 2.32, 5.12, 6.6, 8.12 };

			int index = BinarySearch<double>.Search(array, 5.12);

			Assert.AreEqual(2, index);
		}
	}
}