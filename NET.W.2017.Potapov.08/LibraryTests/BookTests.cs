using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
	[TestClass()]
	public class BookTests
	{
		[TestMethod()]
		public void ToStringTest()
		{
			Book book = new Book("978-0-7356-6745-7", "Jeffrey Richter", "CLR via C#", "Microsoft Press", 2012, 826, (decimal)59.99);

			string resultString = book.ToString("author", "title", "publisher", "price");

			Assert.AreEqual("Jeffrey Richter CLR via C# Microsoft Press $59.99", resultString);
		}

		[TestMethod()]
		[ExpectedException(typeof(ArgumentException))]
		public void ToStringTest_UnexpectedField_Exeption()
		{
			Book book = new Book("978-0-7356-6745-7", "Jeffrey Richter", "CLR via C#", "Microsoft Press", 2012, 826, (decimal)59.99);

			string resultString = book.ToString("UnexpectedField");
		}

		[TestMethod()]
		[ExpectedException(typeof(ArgumentException))]
		public void ToStringTest_DifferentCaseFields_Exeption()
		{
			Book book = new Book("978-0-7356-6745-7", "Jeffrey Richter", "CLR via C#", "Microsoft Press", 2012, 826, (decimal)59.99);

			string resultString = book.ToString("Author", "Title", "Publisher", "Price");
		}

		[TestMethod()]
		[ExpectedException(typeof(NullReferenceException))]
		public void ToStringTest_Null_Exeption()
		{
			Book book = new Book("978-0-7356-6745-7", "Jeffrey Richter", "CLR via C#", "Microsoft Press", 2012, 826, (decimal)59.99);

			string resultString = book.ToString(null);
		}
	}
}