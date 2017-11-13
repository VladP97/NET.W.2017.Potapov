using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : IEquatable<Book>, IComparable<Book>, IFormattable
    {
		private string isbn;
		private string author;
		private string title;
		private string publisher;
		private int publishYear;
		private int pageCount;
		private decimal price;

		public Book(string isbn, string author, string title, string publisher, int publishYear, int pageCount, decimal price)
		{
			this.isbn = isbn;
			this.author = author;
			this.title = title;
			this.publisher = publisher;
			this.publishYear = publishYear;
			this.pageCount = pageCount;
			this.price = price;
		}

		public string ISBN
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

		public override string ToString()
		{
			return ISBN + " " + Author + " " + Title + " " + Publisher + " " + PublishYear + " " + PageCount + " " + Price;
		}

		public string ToString(string format, IFormatProvider provider = null)
		{
			if (string.IsNullOrEmpty(format)) { format = "ALL"; }
			if (provider == null) { provider = CultureInfo.CurrentCulture; }
			if (format.ToUpper() == "ALL")
				return ToString();
			string[] formatList = format.Split(' ');
			string result = "";
			for (int i = 0; i < formatList.Length; i++)
			{
				switch (formatList[i].ToUpper())
				{
					case "AUTHOR":
						result += Author;
						break;
					case "ISBN":
						result += ISBN;
						break;
					case "TITLE":
						result += Title;
						break;
					case "PUBLISHER":
						result += Publisher;
						break;
					case "YEAR":
						result += PublishYear.ToString();
						break;
					case "PAGES":
						result += PageCount.ToString();
						break;
					case "PRICE":
						result += Price.ToString();
						break;
				}
			}
			return result;
		}

		public override int GetHashCode()
		{
			return isbn.GetHashCode() + author.GetHashCode() + title.GetHashCode() + publishYear.GetHashCode() + PageCount + price.GetHashCode();
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
			if (String.Equals(ISBN, book.ISBN))
			{
				return true;
			}
			return false;
		}

		public int CompareTo(Book book)
		{
			return String.Compare(ISBN, book.ISBN);
		}
	}
}
