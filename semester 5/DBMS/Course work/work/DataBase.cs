
using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Security.Cryptography;
using System.Text;

namespace work
{
    enum DataBaseType
    {
        SQLITE,
        MYSQL, 
        POSTGRESQL,
    }
    enum CheckTableResult
    {
        /// <summary>
        /// Таблицы нет
        /// </summary>
        NO,
        /// <summary>
        /// Таблица есть, и её исходный код из запроса, схож с исходным кодом в DataBase классе
        /// </summary>
        YES,
        /// <summary>
        /// Таблица есть, но её исходный код отличается от исходного кода в DataBase классе
        /// </summary>
        ANOTHER
    }


#pragma warning disable CS8618
    public partial class DataBase
    {
        DbConnection connection;
        DbCommand command;
        DataBaseType Type;
        private void Start()
        {
            connection.Open();
            command = connection.CreateCommand();
            CheckTable();
        }
        /*
        public DataBase(string File)
        {
            Type = DataBaseType.SQLITE;
            connection = new SqliteConnection($"Data Source={File}.db");
            Start();
        }
        */
        public DataBase(string Server, ushort Port, string DataBase, string User, string Password)
        {
            Type = DataBaseType.MYSQL;
            MySqlConnectionStringBuilder connections = new MySqlConnectionStringBuilder();
            connections.Server = Server;
            connections.Port = Port;
            connections.Database = DataBase;
            connections.UserID = User;
            connections.Password = Password;

            connection = new MySqlConnection(connections.ConnectionString);
            Start();
        }
        private long GetInsertId()
        {
            switch(Type)
            {
                case DataBaseType.MYSQL:
                    command.CommandText = "SELECT LAST_INSERT_ID() AS `id`";
                    break;
                default:
                    return 0;
            }
            DbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int id = (int)reader["id"];
                reader.Close();
                return id;
            }
            reader.Close();
            return 0;
        }
        private string Password(string password)
        {
            byte[] hashBytes;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                hashBytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
