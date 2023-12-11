using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public partial class DataBase
    {
        public int GetCode(ushort phone)
        {
            command.CommandText = $"SELECT `id` FROM `code` WHERE `phone` = {phone}";
            DbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int id = (int)reader["id"];
                reader.Close();
                return id;
            }
            reader.Close();
            return -1;
        }
        public int GetCode(string country)
        {
            command.CommandText = $"SELECT `id` FROM `code` WHERE `country` = '{country}'";
            DbDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                int id = (int)reader["id"];
                reader.Close();
                return id;
            }
            reader.Close();
            return -1;
        }



    }
}
