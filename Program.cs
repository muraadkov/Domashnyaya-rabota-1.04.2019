using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11._04._2019
{
    class Program
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\АдылкановМ.CORP\source\repos\HomeWork 11.04.2019\HomeWork 11.04.2019\Database.mdf;Integrated Security=True";
        static SqlConnection sqlConnection = null;
        static SqlCommand sqlCommand = null;
        static SqlDataReader reader = null;
        static void Main(string[] args)
        {
            //Напишите код с использованием технологии ADO.NET, который создает в базе данных таблицу gruppa.

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand = new SqlCommand
            ("create table gruppa (Id int primary key identity, Name nvarchar(50) not null)", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Console.ReadKey();
        }
    }
}
