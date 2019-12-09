﻿using System.IO;

namespace TagsCloudContainer.FileManager
{
    public class FileManager : IFileManager
    {
        public string ReadFile(string inputFile)
        {
            using (var file  = new StreamReader(inputFile))
            {
                var result = file.ReadToEnd();
                return result;
            }
        }

        public string MakeFile()
        {
            var fileName = Path.GetTempFileName();
            return fileName;
        }

        public void WriteInFile(string fileName, string text)
        {
            using (var file = new StreamWriter(fileName))
            {
                file.Write(text);
            }
        }
    }
}