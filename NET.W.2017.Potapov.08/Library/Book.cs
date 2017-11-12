using System;
using System.Reflection;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book: IEquatable<Book>, IComparable<Book>, IParamsStringFormatter
    {
		private string isbn;
		private string author;
		private string title;
		private string publisher;
		private int publishYear;
		private int pageCount;
		private decimal price;

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

		public override string ToString()
		{
			return ISBN + " " + Author + " " + Title + " " + Publisher + " " + PublishYear + " " + PageCount + " " + Price;
		}

		public string ToString(params string[] paramsToGenerateString)
		{
			if (paramsToGenerateString == null)
			{
				throw new NullReferenceException();
			}
			FieldInfo[] classFields = typeof(Book).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
			string result = "";
			for (int i = 0; i < classFields.Length; i++)
			{
				for (int j = 0; j < paramsToGenerateString.Length; j++)
				{
					if (classFields[i].Name == paramsToGenerateString[j])
					{
						if (classFields[i].Name == "price")
						{
							result += string.Format(new CultureInfo("en-US"), "{0:C2}", classFields[i].GetValue(this));
						}
						else
						{
							result += classFields[i].GetValue(this).ToString() + " ";
						}
					}
				}
			}
			if (result == "")
			{
				throw new ArgumentException();
			}
			result.Remove(result.Length - 1, 1);
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
