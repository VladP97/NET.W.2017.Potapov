using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
	public static class BookListService
	{
		private static Book CreateBook(string streamReaderString)
		{
			string[] paramsArray = streamReaderString.Split(' ');
			return new Book(int.Parse(paramsArray[0]), paramsArray[1], paramsArray[2], paramsArray[3], int.Parse(paramsArray[4]), int.Parse(paramsArray[5]), decimal.Parse(paramsArray[6]));
		}

		private static List<Book> ReturnBooksList(BinaryReader br)
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
		public static void AddBook(Book book, ICollection<Book> bookListStorage)
		{
			if (book == null)
			{
				throw new NullReferenceException();
			}
			
			if (bookListStorage.Contains(book))
			{
				throw new ArgumentException();
			}
			bookListStorage.Add(book);
		}

		/// <summary>
		/// Removes book from storage.
		/// </summary>
		/// <param name="book">Book to remove</param>
		public static void RemoveBook(Book book, ICollection<Book> bookListStorage)
		{
			if (book == null)
			{
				throw new NullReferenceException();
			}
			if (!bookListStorage.Contains(book))
			{
				throw new ArgumentException();
			}
			bookListStorage.Remove(book);
		}

		/// <summary>
		/// Sorts storage by criteria.
		/// </summary>
		/// <param name="criteria">Object inherited from IComparer interface.</param>
		public static void SortBooksByTag(IComparer<Book> criteria, List<Book> bookListStorage)
		{
			bookListStorage.Sort(criteria);
		}

		/// <summary>
		/// Searchs books by criteria.
		/// </summary>
		/// <param name="criteria">Object inherited from ICompareWithCriteria interface.</param>
		/// <returns>List of Book objects selected by criteria.</returns>
		public static List<Book> SearchBooksByTag(ICompareWithCriteria<Book> criteria, ICollection<Book> bookListStorage)
		{
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
		public static void SaveToBookBinaryFile(string path, ICollection<Book> bookListStorage)
		{
			BinaryWriter br = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate));
			foreach (var book in bookListStorage)
			{
				br.Write(book.ToString());
			}
			br.Close();
		}
	}
}
