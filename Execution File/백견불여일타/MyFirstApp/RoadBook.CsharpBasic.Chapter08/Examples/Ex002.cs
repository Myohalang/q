using System;
using System.IO;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    class Ex002
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            using (StreamWriter sw = new StreamWriter(currentDirectory + @"\data\log.txt", true))
            {
                sw.WriteLine($"프로그램 실행 시간 : {DateTime.Now}");
            }
        }
    }
}
