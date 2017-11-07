using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book: IEquatable<Book>, IComparable<Book>
    {
		private int isbn;
		private string author;
		private string title;
		private string publisher;
		private int publishYear;
		private int pageCount;
		private decimal price;

		public int ISBN
		{
			get
			{
				return isbn;
			}
		}

		public string Author
		{
			get
			{
				return author;
			}
		}

		public string Title
		{
			get
			{
				return title;
			}
		}

		public string Publisher
		{
			get
			{
				return publisher;
			}
		}

		public int PublishYear
		{
			get
			{
				return publishYear;
			}
		}

		public int PageCount
		{
			get
			{
				return pageCount;
			}
		}

		public decimal Price
		{
			get
			{
				return price;
			}
		}

		public Book(int isbn, string author, string title, string publisher, int publishYear, int pageCount, decimal price)
		{
			this.isbn = isbn;
			this.author = author;
			this.title = title;
			this.publisher = publisher;
			this.publishYear = publishYear;
			this.pageCount = pageCount;
			this.price = price;
		}

		public override string ToString()
		{
			return ISBN + " " + Author + " " + Title + " " + Publisher + " " + PublishYear + " " + PageCount + " " + Price;
		}

		public override int GetHashCode()
		{
			return isbn + author.GetHashCode() + title.GetHashCode() + publishYear.GetHashCode() + PageCount + price.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			Book personObj = obj as Book;
			return Equals(personObj);
		}

		public bool Equals(Book book)
		{
			if(book == null)
			{
				return false;
			}
			if (ReferenceEquals(book, this))
			{
				return true;
			}
			if (ISBN == book.ISBN)
			{
				return true;
			}
			return false;
		}

		public int CompareTo(Book book)
		{
			return ISBN - book.ISBN;
		}
	}
}
