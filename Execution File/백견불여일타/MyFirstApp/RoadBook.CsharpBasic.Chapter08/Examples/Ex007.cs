using System;
using System.IO;
using System.Data.SqlClient;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    class Ex007
    {
        private readonly string currectDirectory = Environment.CurrentDirectory;
        private readonly string connectionStr = string.Format($"Data Source = {"127.0.0.1"},{"1433"}; Initial Catalog = {"testdb"}; User ID = {"sa"}; Password = {"1234"}");

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
            SqlConnection connection = new SqlConnection(connectionStr);

            string FileName = string.Format($@"\data\db {DateTime.Now.ToString("yyyy MM dd HH mm ss")}.log");

            using (StreamWriter sw = new StreamWriter(currectDirectory + FileName, true))
            {
                sw.WriteLine($"[{DateTime.Now}] 데이터베이스 연결 시도...");
                connection.Open();
                sw.WriteLine($"[{DateTime.Now}] 데이터베이스 연결 OK...");

                Model.User user = SetUser();

                string updateSQL = string.Format($" UPDATE TB_USER SET NAME = '{user.Name}', Age = '{user.Age}', Job = '{user.Job}' WHERE ID = '{user.userID}' ");

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = updateSQL;

                    int activeNumber = command.ExecuteNonQuery();

                    sw.WriteLine($"영향 받은 데이터 : {activeNumber}");
                }

                sw.WriteLine($"[{DateTime.Now}] 데이터베이스 연결 끊기 시도");
                connection.Close();
                sw.WriteLine($"[{DateTime.Now}] 데이터베이스 연결 끊기 OK...");
            }
        }

        private Model.User SetUser()
        {
            Model.User user = new Model.User();

            bool validate = false;

            do
            {
                Write("정보를 수정할 회원의 아이디를 입력하세요 : ");
                user.userID = ReadLine();
                Write("회원의 이름을 입력하세요 : ");
                user.Name = ReadLine();
                Write("회원의 나이를 입력하세요 : ");
                user.Age = Convert.ToInt32(ReadLine());
                Write("회원의 직업을 입력하세요 : ");
                user.Job = ReadLine();

                WriteLine($"수정된 회원 : {user.userID} / {user.Name} / {user.Age} / {user.Job} 이 맞습니까? (y/n)");

                validate = ReadLine().ToLower() != "y";

            } while (validate);

            return user;
        }
    }
}
