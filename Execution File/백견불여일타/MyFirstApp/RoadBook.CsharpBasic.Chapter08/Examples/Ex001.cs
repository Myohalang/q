using System;
using System.IO;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    class Ex001
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"/data");

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                WriteLine("디렉토리가 생성되었습니다.");
            }

            WriteLine($"생성 경로 : {directoryInfo.FullName}");
        }
    }
}
