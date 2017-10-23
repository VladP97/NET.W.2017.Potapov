using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShift
{
	public static class BinaryNumberShift
	{
		public static int InsertNumber(int numberSource, int numberToInsert, int shift, int shiftTo)
		{
			string binNumberToInsert = Convert.ToString(numberToInsert, 2);
			int bitsToAdd = shiftTo - shift + 1;
			char[] binNumberToInsertCharArray = binNumberToInsert.ToCharArray();
			if (bitsToAdd < binNumberToInsertCharArray.Length)
			{
				Array.Resize(ref binNumberToInsertCharArray, bitsToAdd);
				binNumberToInsert = new string(binNumberToInsertCharArray);
				numberToInsert = Convert.ToInt32(binNumberToInsert, 2);
			}
			return numberSource | numberToInsert << shift;
		}
	}
}
