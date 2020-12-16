using System;
using System.IO;

namespace _01.Logger.IOManagement.Interfaces
{
    public class FileWriter : IWriter
    {
        public FileWriter(string filePath)
        {
            this.FilePath = filePath;
        }

        public string FilePath { get; }
        public void Write(string text)
        {
            File.WriteAllText(this.FilePath, text);
        }

        public void WriteLine(string text)
        {
            File.WriteAllText(this.FilePath, text + Environment.NewLine);

        }
    }
}
