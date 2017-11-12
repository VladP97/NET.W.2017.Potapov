using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library.Tests
{
	//public class SortByISBN: IComparer<Book>
	//{
	//	public int Compare(Book firstBook, Book secondBook)
	//	{
	//		return firstBook.ISBN - secondBook.ISBN;
	//	}
	//}

	//public class SelectByYear: ICompareWithCriteria<Book>
	//{
	//	public bool Compare(Book book)
	//	{
	//		return book.PublishYear == 1986 ? true : false;
	//	}
	//}

	//[TestClass()]
	//public class BookListServiceTests
	//{
	//	[TestMethod()]
	//	public void AddBook()
	//	{
	//		BookListService bls = new BookListService("Test1.bin");

	//		bls.AddBook(new Book(345123233, "Author1", "Title1", "Publisher1", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123235, "Author2", "Title2", "Publisher3", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123234, "Author3", "Title3", "Publisher3", 1987, 355, (decimal)9.99));
	//		List<Book> BookListStorage = bls.SaveToBookListStorage();
	//	}

	//	[TestMethod()]
	//	public void RemoveBook()
	//	{
	//		BookListService bls = new BookListService("Test2.bin");
	//		List<Book> bookList = new List<Book>
	//		{
	//			new Book(345123233, "Author1", "Title1", "Publisher1", 1986, 345, (decimal)9.99),
	//			new Book(345123235, "Author2", "Title2", "Publisher3", 1986, 345, (decimal)9.99)
	//		};
	//		bls.AddBook(new Book(345123233, "Author1", "Title1", "Publisher1", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123235, "Author2", "Title2", "Publisher3", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123234, "Author3", "Title3", "Publisher3", 1987, 355, (decimal)9.99));
	//		bls.RemoveBook(new Book(345123234, "Author3", "Title3", "Publisher3", 1987, 355, (decimal)9.99));

	//		CollectionAssert.AreEqual(bookList, bls.SaveToBookListStorage());
	//	}

	//	[TestMethod()]
	//	[ExpectedException(typeof(ArgumentException))]
	//	public void RemoveNonexistentBook()
	//	{
	//		BookListService bls = new BookListService("Test3.bin");

	//		bls.AddBook(new Book(345123233, "Author1", "Title1", "Publisher1", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123235, "Author2", "Title2", "Publisher3", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123234, "Author3", "Title3", "Publisher3", 1987, 355, (decimal)9.99));
	//		bls.RemoveBook(new Book(345123232, "Author3", "Title12", "Publisher3", 3007, 355, (decimal)9.99));
	//	}

	//	[TestMethod()]
	//	[ExpectedException(typeof(ArgumentException))]
	//	public void AddExistedBook()
	//	{
	//		BookListService bls = new BookListService("Test4.bin");

	//		bls.AddBook(new Book(345123233, "Author1", "Title1", "Publisher1", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123235, "Author2", "Title2", "Publisher3", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123235, "Author2", "Title2", "Publisher3", 1986, 345, (decimal)9.99));
	//	}

	//	[TestMethod()]
	//	public void SearchBooksByTag()
	//	{
	//		BookListService bls = new BookListService("Test5.bin");
	//		List<Book> bookList = new List<Book>
	//		{
	//			new Book(345123233, "Author1", "Title1", "Publisher1", 1986, 345, (decimal)9.99),
	//			new Book(345123235, "Author2", "Title2", "Publisher3", 1986, 345, (decimal)9.99)
	//		};
	//		bls.AddBook(new Book(345123233, "Author1", "Title1", "Publisher1", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123235, "Author2", "Title2", "Publisher3", 1986, 345, (decimal)9.99));
	//		bls.AddBook(new Book(345123234, "Author3", "Title3", "Publisher3", 1987, 355, (decimal)9.99));
	//		List<Book> resultList = bls.SearchBooksByTag(new SelectByYear());

	//		CollectionAssert.AreEqual(bookList, resultList);
	//	}
	//}
}