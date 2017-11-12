using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace LibraryExample
{ 
	class Program
	{
		static void Main(string[] args)
		{
			//BookListService bls = new BookListService("Example.bin");

			//bls.AddBook(new Book(345123233, "Author1", "Title1", "Publisher1", 2000, 345, (decimal)9.99));
			//bls.AddBook(new Book(345123235, "Author2", "Title2", "Publisher3", 2006, 345, (decimal)9.99));
			//bls.AddBook(new Book(345123234, "Author3", "Title3", "Publisher3", 2006, 355, (decimal)9.99));

			//Console.WriteLine("Write all books");
			//foreach (var book in bls.SaveToBookListStorage())
			//{
			//	Console.WriteLine(book);
			//}
			//Console.WriteLine();

			//Console.WriteLine("Books selected by 2006 year");
			//List<Book> selectedByYearBooks = bls.SearchBooksByTag(new SelectByYear());
			//foreach (var book in selectedByYearBooks)
			//{
			//	Console.WriteLine(book);
			//}
			//Console.WriteLine();

			//bls.RemoveBook(new Book(345123235, "Author2", "Title2", "Publisher3", 2006, 345, (decimal)9.99));
			//Console.WriteLine("Books after deleted");
			//foreach (var book in selectedByYearBooks)
			//{
			//	Console.WriteLine(book);
			//}
			//Console.ReadLine();
		}
	}
}
