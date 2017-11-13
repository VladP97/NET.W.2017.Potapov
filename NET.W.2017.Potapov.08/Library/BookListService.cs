using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
	public class BookListService : IStorage<Book>
	{
		private List<Book> storage;

		public BookListService()
		{
			storage = new List<Book>();
		}

		public BookListService(IEnumerable<Book> storage)
		{
			this.storage = new List<Book>(storage);
		}

		public BookListService(string path)
		{
			storage = new List<Book>();
			using (BinaryReader br = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate)))
			{
				while (br.PeekChar() != -1)
				{
					storage.Add(CreateBook(br.ReadString()));
				}
			}
		}

		private static Book CreateBook(string streamReaderString)
		{
			string[] paramsArray = streamReaderString.Split(' ');
			return new Book(paramsArray[0], paramsArray[1], paramsArray[2], paramsArray[3], int.Parse(paramsArray[4]), int.Parse(paramsArray[5]), decimal.Parse(paramsArray[6]));
		}

		/// <summary>
		/// Adds new book to storage.
		/// </summary>
		/// <param name="book">Book to add.</param>
		public void AddElement(Book book)
		{
			if (book == null)
			{
				throw new NullReferenceException();
			}		
			if (storage.Contains(book))
			{
				throw new ArgumentException();
			}
			storage.Add(book);
		}

		/// <summary>
		/// Removes book from storage.
		/// </summary>
		/// <param name="book">Book to remove</param>
		public void RemoveElement(Book book)
		{
			if (book == null)
			{
				throw new NullReferenceException();
			}
			if (!storage.Contains(book))
			{
				throw new ArgumentException();
			}
			storage.Remove(book);
		}

		/// <summary>
		/// Sorts storage by criteria.
		/// </summary>
		/// <param name="criteria">Object inherited from IComparer interface.</param>
		public void SortElementsByTag(IComparer<Book> criteria)
		{
			storage.Sort(criteria);
		}

		/// <summary>
		/// Searchs books by criteria.
		/// </summary>
		/// <param name="criteria">Object inherited from ICompareWithCriteria interface.</param>
		/// <returns>List of Book objects selected by criteria.</returns>
		public IEnumerable<Book> SearchElementByTag(ICompareWithCriteria<Book> criteria)
		{
			List<Book> selectedBooks = new List<Book>();
			foreach (var book in storage)
			{
				if (criteria.Compare(book))
				{
					yield return book;
				}
			}
		}

		public Book SearchFirstElementByTag(ICompareWithCriteria<Book> criteria)
		{
			List<Book> selectedBooks = new List<Book>();
			foreach (var book in storage)
			{
				if (criteria.Compare(book))
				{
					return book;
				}
			}
			return null;
		}

		/// <summary>
		/// Saves books from storage to List.
		/// </summary>
		/// <returns>List of Book object.</returns>
		public void SaveElementToFile(string path)
		{
			using (BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate)))
			{
				foreach (var book in storage)
				{
					bw.Write(book.ToString());
				}
			}
		}
	}
}
