﻿using System;
using System.IO;

namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MoveFile();
        }
        public static void MoveFile()
        {
            string sourceDirectory = @"C:\Users\opilane\samples\PlayerOne";
            string destinationPath = @"C:\Users\opilane\samples\PlayerTwo";
            string fileName = "ball.txt.";

            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));

        }
    }
}
