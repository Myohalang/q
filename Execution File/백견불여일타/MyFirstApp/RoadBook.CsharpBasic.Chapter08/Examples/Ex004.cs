﻿using System;
using System.IO;
using System.Data.SqlClient;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    class Ex004
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;
        private readonly string connectionStr = string.Format($"Data Source = {"127.0.0.1"}, {1433}; Initial Catalog = {"testdb"}; User ID = {"sa"}; Password = {"1234"}");

        public void Run()
        {
            CheckedDirectory();
            TryConnectToDatabase();
        }

        private void CheckedDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\data");

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        private void TryConnectToDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionStr);

            string fileName = string.Format($@"\data\db {DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss")}.log");

            using (StreamWriter sw = new StreamWriter(currentDirectory + fileName, true))
            {
                sw.WriteLine($"[{DateTime.Now}] 데이터베이스 연결 시도...");
                connection.Open();
                sw.WriteLine($"[{DateTime.Now}] 데이터베이스 연결 OK...");

                sw.WriteLine($"[{DateTime.Now}] 데이터베이스 연결 끊기 시도...");
                connection.Close();
                sw.WriteLine($"[{DateTime.Now}] 데이터베이스 연결 끊기 OK...");
            }
        }
    }
}
