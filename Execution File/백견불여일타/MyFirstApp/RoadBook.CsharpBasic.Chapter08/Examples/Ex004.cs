using System;
using System.IO;
using System.Data.SqlClient;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    class Ex004
    {
        private readonly string correntDirectory = Environment.CurrentDirectory;
        private readonly string connectionStr = string.Format($"Data Source = {"127.0.0.1"}, {1433}; Initial Catalog = {"testdb"}; User ID = {"sa"}; Password = {"1234"}");

        public void Run()
        {

        }

        private void CheckedDirectory()
        {

        }

        private void TryConnectToDatabase()
        {

        }
    }
}
