using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public partial class DataBase
    {
        public void AddCode(ushort code, string country)
        {
            if(country.Length != 3)
            {
                throw new Exception("Название страны, должно быть из 3 букв!");
            }
            country = country.ToLower();
            if (GetCode(country) >= 0)
            {
                throw new Exception($"Код страны ({country}), уже используется!");
            }

            command.CommandText = $"SELECT COUNT(*) AS `count` FROM `code`";
            DbDataReader reader = command.ExecuteReader();
            reader.Read();
            int id = (int)(long)reader["count"];
            reader.Close();

            command.CommandText = $"INSERT INTO `code` (`id`, `country`, `phone`) VALUE ({id} ,'{country}', {code})";
            command.ExecuteNonQuery();
        }
        /*public void AddUser(string name, string surname, string password, long phoneNumber)
        {
            const long phoneLength = 10000000000;
            if(phoneNumber < phoneLength)
            {
                throw new Exception($"({phoneNumber}) - не является номером телефона, необходимо минимум 11 цифр");
            }
            long phone = phoneNumber % phoneLength;
            int phone_code = GetCode((ushort)(phoneNumber / phoneLength));
            if(phone_code == -1)
            {
                throw new Exception($"код телефона ({phoneNumber / phoneLength}) не поддерживается");
            }

        }*/
    }
}
