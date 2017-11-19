using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchLibrary
{
    public static class BinarySearch<T>
    {
		public static int Search(T[] array, T valueToSearch)
		{
			int index = -1;
		    index = SearchArray(array, valueToSearch);
			return index;
		}

        private static bool IsSorted(dynamic array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
                if (array[i] > array[i + 1])
                {
                    Console.WriteLine('q');
                    return false;
                }
            }
            return true;
        }

		private static int SearchArray(T[] array, T valueToSearch)
		{
			dynamic[] newArray = new dynamic[array.Length - 1];
            if (!IsSorted(array))
            {
                throw new ArgumentException();
            }
			for (int i = 0; i < newArray.Length; i++)
			{
				newArray[i] = array[i];
			}
			try
			{
				while (valueToSearch != newArray[newArray.Length / 2])
				{
					if (newArray[newArray.Length / 2] > valueToSearch)
					{
						Array.Resize(ref newArray, newArray.Length / 2);
					}
					else
					{
						Array.Reverse(newArray);
						Array.Resize(ref newArray, newArray.Length / 2); ;
						Array.Reverse(newArray);
					}
				}
			}
			catch (IndexOutOfRangeException)
			{
				return -1;
			}
			return newArray.Length / 2;
		}
	}
}
