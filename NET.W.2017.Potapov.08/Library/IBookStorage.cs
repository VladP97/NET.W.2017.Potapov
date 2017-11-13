using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	interface IStorage<T>
	{
		void AddElement(T element);

		void RemoveElement(T element);

		void SortElementsByTag(IComparer<T> tag);

		IEnumerable<T> SearchElementByTag(ICompareWithCriteria<T> tag);

		void SaveElementToFile(string path);
	}
}
