using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Solution;

namespace Task2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomCharsFileGenerator rcfg = new RandomCharsFileGenerator(".txt", "Files with random chars");
            rcfg.GenerateFiles(1, 15, new CharGenerator());
            RandomBytesFileGenerator rbfg = new RandomBytesFileGenerator(".txt", "Files with random bytes");
            rbfg.GenerateFiles(1, 15, new BytesGenerator());
        }
    }
}
