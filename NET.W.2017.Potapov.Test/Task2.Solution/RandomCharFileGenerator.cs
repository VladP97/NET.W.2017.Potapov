using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public class RandomCharsFileGenerator : RandomFileGenerator<char>
    {
        public RandomCharsFileGenerator(string FileExtension, string WorkingDirectory) : base(FileExtension, WorkingDirectory)
        {
        }
    }
}
