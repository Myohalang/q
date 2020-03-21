using System;
using System.IO;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    class Ex003
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            FileInfo fileInfo = new FileInfo(currentDirectory + @"\data\log.txt");

            WriteLine($"저장 경로 : {fileInfo.DirectoryName}");
            WriteLine($"파일명 : {fileInfo.Name}");

            WriteLine("----- 파일 내용 -----");

            using (StreamReader sr = new StreamReader(fileInfo.FullName))
            {
                string line = string.Empty;

                while ((line = sr.ReadLine()) != null)
                {
                    WriteLine(line);
                }
            }
        }
    }
}
