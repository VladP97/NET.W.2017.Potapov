using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public abstract class RandomFileGenerator<T>
    {
        public string WorkingDirectory;

        public string FileExtension;

        public RandomFileGenerator(string FileExtension, string WorkingDirectory)
        {
            this.FileExtension = FileExtension;
            this.WorkingDirectory = WorkingDirectory;
        }

        public void GenerateFiles(int filesCount, int contentLength, IGenerator<T> generator)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength, generator);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteToFile(generatedFileName, generatedFileContent);
            }
        }

        private T[] GenerateFileContent(int contentLength, IGenerator<T> generator)
        {
            return generator.GetSequence(contentLength);
        }

        private void WriteToFile(string fileName, T[] generatedFileContent)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            string[] stringFileContent = new string[generatedFileContent.Length];

            for (int i = 0; i < generatedFileContent.Length; i++)
            {
                stringFileContent[i] = generatedFileContent[i].ToString();
            }

            File.WriteAllLines($"{WorkingDirectory}//{fileName}", stringFileContent);
        }
    }
}
