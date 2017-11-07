using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
	public class BookListService
	{
		private string path;

		/// <summary>
		/// Creates object of BookListService.
		/// </summary>
		/// <param name="path">Path to save binary storage file.</param>
		public BookListService(string path)
		{
			this.path = path ?? throw new NullReferenceException();
			BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate));
			bw.Close();
		}

		/// <summary>
		/// Creates object of BookListService from existing List of books.
		/// </summary>
		/// <param name="bookList">List of Book for storage.</param>
		/// <param name="path">Path to save binary storage file.</param>
		public BookListService(List<Book> bookList, string path)
		{
			this.path = path ?? throw new NullReferenceException();
			if (bookList == null)
			{
				throw new NullReferenceException();
			}
			BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate));
			foreach (var book in bookList)
			{
				bw.Write(book.ToString());
			}
			bw.Close();
		}

		private Book CreateBook(string streamReaderString)
		{
			string[] paramsArray = streamReaderString.Split(' ');
			return new Book(int.Parse(paramsArray[0]), paramsArray[1], paramsArray[2], paramsArray[3], int.Parse(paramsArray[4]), int.Parse(paramsArray[5]), decimal.Parse(paramsArray[6]));
		}

		private List<Book> ReturnBooksList(BinaryReader br)
		{
			List<Book> bookListStorage = new List<Book>();
			while (br.PeekChar() != -1)
			{
				bookListStorage.Add(CreateBook(br.ReadString()));
			}
			br.Close();
			return bookListStorage;
		}

		/// <summary>
		/// Adds new book to storage.
		/// </summary>
		/// <param name="book">Book to add.</param>
		public void AddBook(Book book)
		{
			if (book == null)
			{
				throw new NullReferenceException();
			}
			List<Book> bookListStorage = ReturnBooksList(new BinaryReader(File.Open(path, FileMode.Open)));
			if (bookListStorage.Contains(book))
			{
				throw new ArgumentException();
			}
			BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Append));
			bw.Write(book.ToString());
			bw.Close();
			bookListStorage.Add(book);
		}

		/// <summary>
		/// Removes book from storage.
		/// </summary>
		/// <param name="book">Book to remove</param>
		public void RemoveBook(Book book)
		{
			if (book == null)
			{
				throw new NullReferenceException();
			}
			List<Book> bookListStorage = ReturnBooksList(new BinaryReader(File.Open(path, FileMode.Open)));
			if (!bookListStorage.Contains(book))
			{
				throw new ArgumentException();
			}
			bookListStorage.Remove(book);
			BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create));
			foreach (var bookToWrite in bookListStorage)
			{
				bw.Write(bookToWrite.ToString());
			}
			bw.Close();
		}

		/// <summary>
		/// Sorts storage by criteria.
		/// </summary>
		/// <param name="criteria">Object inherited from IComparer interface.</param>
		public void SortBooksByTag(IComparer<Book> criteria)
		{
			List<Book> bookListStorage = ReturnBooksList(new BinaryReader(File.Open(path, FileMode.Open)));
			bookListStorage.Sort(criteria);
			BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create));
			foreach (var bookToWrite in bookListStorage)
			{
				bw.Write(bookToWrite.ToString());
			}
			bw.Close();
		}

		/// <summary>
		/// Searchs books by criteria.
		/// </summary>
		/// <param name="criteria">Object inherited from ICompareWithCriteria interface.</param>
		/// <returns>List of Book objects selected by criteria.</returns>
		public List<Book> SearchBooksByTag(ICompareWithCriteria<Book> criteria)
		{
			List<Book> bookListStorage = ReturnBooksList(new BinaryReader(File.Open(path, FileMode.Open)));
			List<Book> selectedBooks = new List<Book>();
			foreach (var book in bookListStorage)
			{
				if (criteria.Compare(book))
				{
					selectedBooks.Add(book);
				}
			}
			return selectedBooks;
		}

		/// <summary>
		/// Saves books from storage to List.
		/// </summary>
		/// <returns>List of Book object.</returns>
		public List<Book> SaveToBookListStorage()
		{
			return ReturnBooksList(new BinaryReader(File.Open(path, FileMode.Open)));
		}
	}
}
