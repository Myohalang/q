using System;
using System.Data.SqlClient;
using static System.Console;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    class Ex006
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;
        private readonly string connectionStr = string.Format($"Data Source = {"127.0.0.1"}, {1433}; Initial Catalog = {"testdb"}; User ID = {"sa"}; Password = {"1234"}");

        public void Run()
        {
            string selectSQL = "SELECT ID, NAME, AGE, JOB FROM TB_USER";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectSQL, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        WriteLine($"회원ID : {reader["ID"]}");
                        WriteLine($"회원이름 : {reader["NAME"]}");
                        WriteLine($"회원나이 : {reader["AGE"]}");
                        WriteLine($"회원직업 : {reader["JOB"]}");
                        WriteLine("=====");
                    }
                }

                connection.Close();
            }
        }
    }
}
