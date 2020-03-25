using System;
using System.IO;
using System.Data.SqlClient;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    class Ex008
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;
        private readonly string ConnectionStr = String.Format($"Data Source = {"127.0.0.1"}, {"1433"}; Initial Catalog = {"testdb"}; User = {"sa"}; Password = {"1234"}");

        public void Run()
        {
            CheckedDirectory();
            TryConnectToDatabase();

        }

        private void CheckedDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo($"currentDirectory{@"\data"}");

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        private void TryConnectToDatabase()
        {
            SqlConnection connection = new SqlConnection(ConnectionStr);
        }
    }
}
