using Microsoft.VisualStudio.TestTools.UnitTesting;
using BNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace BNS.Tests
{
	[TestClass()]
	public class BinarySearchTreeTests
	{
		public struct TestStruct
		{
			int testField;

			string stringTestField;

			public TestStruct(int testField, string stringTestField)
			{
				this.testField = testField;
				this.stringTestField = stringTestField;
			}

			public override string ToString()
			{
				return testField.ToString() + " " + stringTestField;
			}
		}

		public class TestIComparerClass : IComparer<TestIComparerClass>
		{
			int testField;

			public TestIComparerClass(int testField)
			{
				this.testField = testField;
			}

			public int Compare(TestIComparerClass obj1, TestIComparerClass obj2)
			{
				return obj1.testField - obj2.testField;
			}

			public override string ToString()
			{
				return testField.ToString();
			}
		}

		[TestMethod()]
		public void BinarySearchTreePreorder()
		{
			BinarySearchTree<int> bns = new BinarySearchTree<int>(25);
			List<int> expected = new List<int>() { 25, 45, 10, 15 };

			bns.Add(45);
			bns.Add(10);
			bns.Add(15);
			List<int> result = new List<int>();
			foreach (var item in bns.PreorderPassage())
			{
				result.Add(item);
			}

			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BinnarySearchTreeInorder()
		{
			BinarySearchTree<int> bns = new BinarySearchTree<int>(25);
			List<int> expected = new List<int>() { 45, 25, 10, 15 };

			bns.Add(45);
			bns.Add(10);
			bns.Add(15);
			List<int> result = new List<int>();
			foreach (var item in bns.InorderPassage())
			{
				result.Add(item);
			}

			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BinnarySearchTreePostorder()
		{
			BinarySearchTree<int> bns = new BinarySearchTree<int>(25);
			List<int> expected = new List<int>() { 45, 10, 15, 25 };

			bns.Add(45);
			bns.Add(10);
			bns.Add(15);
			List<int> result = new List<int>();
			foreach (var item in bns.PostorderPassage())
			{
				result.Add(item);
			}

			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BinnarySearchTreeDelete()
		{
			BinarySearchTree<int> bns = new BinarySearchTree<int>(25);
			List<int> expected = new List<int>() { 45, 25 };

			bns.Add(45);
			bns.Add(10);
			bns.Add(15);
			bns.Delete(10);
			List<int> result = new List<int>();
			foreach (var item in bns.InorderPassage())
			{
				result.Add(item);
			}

			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BinnarySearchTreeContains()
		{
			BinarySearchTree<int> bns = new BinarySearchTree<int>(25);

			bns.Add(45);
			bns.Add(10);
			bns.Add(15);

			Assert.AreEqual(bns.Contains(10), true);
		}

		[TestMethod()]
		public void BinnarySearchTreeContains_FalseResult()
		{
			BinarySearchTree<int> bns = new BinarySearchTree<int>(25);

			bns.Add(45);
			bns.Add(10);
			bns.Add(15);

			Assert.AreEqual(bns.Contains(12), false);
		}

		[TestMethod()]
		public void BinnarySearchTreeBook()
		{
			BinarySearchTree<Book> bns = new BinarySearchTree<Book>(new Book("978-0-7356-6745-7", "Jeffrey Richter", "CLR via C#", "Microsoft Press", 2012, 826, (decimal)59.99));

			bns.Add(new Book("978-1-6172-9134-0", "Jon Skeet", "C# IN DEPTH", "Microsoft Press", 2013, 826, (decimal)35.99));
			bns.Add(new Book("978-1-4919-2706-9", "Joseph Albahari", "C# 6.0 in a Nutshell", "Microsoft Press", 2013, 826, (decimal)50.99));
			bns.Add(new Book("978-1-4919-8765-0", "Joseph Albahari", "C# 7.0 in a Nutshell", "Microsoft Press", 2013, 826, (decimal)50.99));

			foreach (var item in bns.InorderPassage())
			{
				Console.WriteLine(item);
			}
		}

		[TestMethod()]
		public void BinnarySearchTreeUserStructTest()
		{
			BinarySearchTree<TestStruct> bns = new BinarySearchTree<TestStruct> (new TestStruct(1, "FirstTestField"));

			bns.Add(new TestStruct(2, "SecondTestField"));
			bns.Add(new TestStruct(3, "ThirdTestField"));
			bns.Add(new TestStruct(4, "FourthTestField"));

			foreach (var item in bns.InorderPassage())
			{
				Console.WriteLine(item);
			}
		}

		[TestMethod()]
		public void BinnarySearchTreeUserClassWithCustomIComparableTest()
		{
			BinarySearchTree<TestIComparerClass> bns = new BinarySearchTree<TestIComparerClass>(new TestIComparerClass(1));

			bns.Add(new TestIComparerClass(2));
			bns.Add(new TestIComparerClass(3));
			bns.Add(new TestIComparerClass(4));
			foreach (var item in bns.InorderPassage())
			{
				Console.WriteLine(item);
			}
		}
	}
}