using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace LibraryExample
{
	public class SelectByYear : ICompareWithCriteria<Book>
	{
		public bool Compare(Book book)
		{
			return book.PublishYear == 2006 ? true : false;
		}
	}
}
