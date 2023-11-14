using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    struct DataBaseColumn
    {
        string Name;
        string Type;
        public DataBaseColumn(string Name, string Type)
        {
            this.Name = Name;
            this.Type = Type;
        }
    }
    public partial class DataBase
    {
        void CheckTable()
        {
            CheckTableCode();
            CheckTableRegistration();

            CheckTableWall();
            CheckTableGroup();
            CheckTablePhoto();
            CheckTablePhotoAlbum();
            CheckTableMusicAlbum();
            CheckTableMusicArtist();

            CheckTableUserLogin();
            CheckTableUser();
            CheckTableUserEmail();
            CheckTableUserInteractive();

            CheckTableTag();
            CheckTableTagUser();
            CheckTableTagGroup();
            CheckTableTagArtist();

            CheckTableUUID();
            CheckTableSession();
        }
        bool CheckTable(string Name, params DataBaseColumn[] columns)
        {
            bool result = false;
            //command.CommandText = $"SELECT * FROM sqlite_master WHERE type='table' AND name='{Name}';";
            command.CommandText = $"PRAGMA table_info({Name})";
            /*
=================
cid|name|type|notnull|dflt_value|pk|
=================
0|c1|INTEGER|0||0|
========
1|c2|TEXT|0||0|
========
2|c3|REAL|0||0|
========
            */
            SqliteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Debug.WriteLine("\n=================");
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Debug.Write(reader.GetName(i) + "|");
                }
                Debug.WriteLine("\n=================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Debug.Write(reader[reader.GetName(i)] + "|");
                    }
                    Debug.WriteLine("\n========");
                }
                if (columns == null || columns.Length == 0)
                {
                    result = true;
                }
            }
            reader.Close();
            return result;
        }

        void CheckTableCode()
        {

        }
        void CheckTableRegistration() 
        { 

        }
        void CheckTableUUID()
        {

        }
        void CheckTableUserLogin()
        {

        }
        void CheckTableUser()
        {

        }
        void CheckTableUserEmail()
        {

        }
        void CheckTableSession()
        {

        }
        void CheckTableUserInteractive()
        {

        }
        void CheckTableWall()
        {

        }
        void CheckTablePhotoAlbum()
        {

        }
        void CheckTablePhoto()
        {

        }
        void CheckTableGroup()
        {

        }
        void CheckTableMusicAlbum()
        {

        }
        void CheckTableMusicArtist()
        {

        }

        void CheckTableTag()
        {

        }
        void CheckTableTagUser()
        {

        }
        void CheckTableTagGroup()
        {

        }
        void CheckTableTagArtist()
        {

        }
    }
}
