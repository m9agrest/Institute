using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Finisar.SQLite;

namespace Work
{
    internal class DataBase
    {
        SQLiteConnection connection;

        public DataBase(string name)
        {
            string s = Path.Combine(Application.StartupPath, name + ".db");
            connection = new SQLiteConnection();
            if (File.Exists(s))
            {
                connection.ConnectionString = @"Data Source=" + s + ";New=False;Version=3";
            }
            else
            {
                connection.ConnectionString = @"Data Source=" + s + ";New=True;Version=3";
            }
            connection.Open(); // .Close();
        }


        public bool CreateTable(string name)
        {
            int code = 0;
            try
            {
                using (SQLiteCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "CREATE TABLE " + name;
                    code = sqlCommand.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            return code != 0;
        }
        public bool AddColumnForTable(string nameTable, string nameColumn)
        {

            DataRow[] datarows = null;
            SQLiteDataAdapter dataadapter = null;
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();

            int code = 0;

            try
            {
                using (SQLiteCommand sqlCommand = connection.CreateCommand())
                {
                    dataadapter = new SQLiteDataAdapter($"SHOW COLUMNS FROM `{nameTable}` LIKE '{nameColumn}'", connection);
                    dataset.Reset();
                    dataadapter.Fill(dataset);
                    datatable = dataset.Tables[0];
                    datarows = datatable.Select();
                    if (datarows.Length == 0)
                    {
                        sqlCommand.CommandText = $"ALTER {nameTable} ADD COLUMN {nameColumn} VARCHAR (20)";
                        code = sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                return false;
            }

            return code != 0;
        }
        public bool AddData(string name, params string[] data)
        {
            string str = "(";
            for(int i = 0; i < data.Length; i++)
            {
                str += $"'{data[i]}'";
                if(i + 1 != data.Length)
                {
                    str += ',';
                }
            }
            str += ')';

            int code = 0;
            try
            {
                using (SQLiteCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = $"INSERT INTO {name} value {str}";
                    code = sqlCommand.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            return code != 0;
        }
        public string[,] GetTable(string name)
        {
            string[,] ret = null;
            DataRow[] datarows = null;
            SQLiteDataAdapter dataadapter = null;
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            int code = 0;

            try
            {
                using (SQLiteCommand sqlCommand = connection.CreateCommand())
                {
                    dataadapter = new SQLiteDataAdapter($"SELECT * FROM `{name}`", connection);
                    dataset.Reset();
                    dataadapter.Fill(dataset);
                    datatable = dataset.Tables[0];
                    datarows = datatable.Select();
                    ret = new string[datarows.Length + 1, datatable.Columns.Count];
                    for(int i = 0; i < ret.GetLength(1); i++)
                    {
                        ret[0, i] = datatable.Columns[i].ColumnName;
                    }
                    for(int j = 0; j < datarows.Length; j++)
                    {
                        for (int i = 0; i < ret.GetLength(1); i++)
                        {
                            ret[j + 1, i] = datarows[j][ret[0, i]].ToString();
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return ret;
        }
        public List<string> GetTableList()
        {
            string[] array = Directory.GetFiles(Application.StartupPath);
            List<string> list = new List<string>();
            foreach (string file in array)
            {
                string[] n = file.Split(".");
                if (n.Length == 2 && n[1] == "db")
                {
                    list.Add(n[0]);
                }
            }
            return list;
        }
    }
}
