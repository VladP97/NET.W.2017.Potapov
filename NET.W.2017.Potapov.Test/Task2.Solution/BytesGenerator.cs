using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public class BytesGenerator : IGenerator<byte>
    {
        public byte[] GetSequence(int Size)
        {
            var random = new Random();

            var fileContent = new byte[Size];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
