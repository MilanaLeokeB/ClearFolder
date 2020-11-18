using System;
using System.IO;

namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void CreateFolderOne()
        {
            string folderootPath = @"C:\Users\opilane\samples";
            string FolderName = "playOne";
            string fullFolderPath = Path.Combine(folderootPath, FolderName);
            Console.WriteLine(fullFolderPath);

        }
    }
}
