using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchLibrary
{
    public static class BinarySearch<T1, T2>
    {
		public static int Search(T1 array, T2 valueToSearch)
		{
			int index = -1;
			if (array.GetType().IsArray)
			{
				index = SearchArray(array, valueToSearch);
			}
			else if (array is ICollection<T2>)
			{
				index = ToArray(array, valueToSearch);
			}
			return index;
		}

		private static int SearchArray(dynamic array, dynamic valueToSearch)
		{
			dynamic[] newArray = new dynamic[array.Length - 1];
			for (int i = 0; i < newArray.Length; i++)
			{
				newArray[i] = array[i];
			}
			Array.Sort(newArray);
			try
			{
				while (valueToSearch != newArray[(int)newArray.Length / 2])
				{
					if (newArray[(int)newArray.Length / 2] > valueToSearch)
					{
						Array.Resize(ref newArray, (int)newArray.Length / 2);
					}
					else
					{
						Array.Reverse(newArray);
						Array.Resize(ref newArray, (int)newArray.Length / 2); ;
						Array.Reverse(newArray);
					}
				}
			}
			catch (IndexOutOfRangeException)
			{
				return -1;
			}
			return (int)newArray.Length / 2;
		}

		private static int ToArray(dynamic array, dynamic valueToSearch)
		{
			if (array is List<T2>)
			{
				var newArray = array.ToArray();
				return SearchArray(newArray, valueToSearch);
			}
			if (array is HashSet<T2>)
			{
				var newArray = new T2[array.Count];
				array.CopyTo(newArray);
				return SearchArray(newArray, valueToSearch);
			}
			return -1;
		}

	}
}
