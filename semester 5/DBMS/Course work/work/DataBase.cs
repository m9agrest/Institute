using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public partial class DataBase
    {
        SqliteConnection connection;
        SqliteCommand command;
        public DataBase(string FileName)
        {
            connection = new SqliteConnection($"Data Source={FileName}.db"); 
            connection.Open();
            command = connection.CreateCommand();

            CheckTable("Test");

            /*if (!CheckTable("Test"))
            {
                command.CommandText = "CREATE TABLE Test(c1 INTEGER,c2 TEXT,c3 REAL)";
                command.ExecuteNonQuery();
                CheckTable("Test");
            }*/
        }



    }
}
