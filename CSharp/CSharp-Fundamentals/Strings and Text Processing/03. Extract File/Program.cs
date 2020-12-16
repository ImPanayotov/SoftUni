using System;
using System.IO;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string[] pathArgs = path
                .Split('\\', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] fileInfo = pathArgs.Last().Split('.', StringSplitOptions.RemoveEmptyEntries);

            //string[] fileNameArgs = fileInfo.Take(fileInfo.Length - 1).ToArray();
            string fileName = fileInfo[0];
            string fileExt = fileInfo[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExt}");
        }
    }
}
