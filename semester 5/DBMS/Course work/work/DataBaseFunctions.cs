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

        public void Registration(string name, string surname, string password, long phoneNumber, DateTime birth)
        {
            const long phoneLength = 10000000000;
            if (phoneNumber < phoneLength)
            {
                throw new Exception($"({phoneNumber}) - не является номером телефона, необходимо минимум 11 цифр");
            }
            long phone = phoneNumber % phoneLength;
            int phone_code = GetCode((ushort)(phoneNumber / phoneLength));
            if (phone_code == -1)
            {
                throw new Exception($"код телефона ({phoneNumber / phoneLength}) не поддерживается");
            }
            command.CommandText = $"SELECT (SELECT COUNT(*) FROM `user_login` WHERE `phone_code` = {phone_code} AND `phone` = {phone}) AS `count1`,(SELECT COUNT(*) FROM `registration` WHERE `phone_code` = {phone_code} AND `phone` = {phone}) AS `count2`";
            DbDataReader reader = command.ExecuteReader();
            reader.Read();
            if ((long)reader["count1"] != 0 || (long)reader["count2"] != 0)
            {
                reader.Close();
                throw new Exception("Данный номер телефона, уже используется!");
            }
            reader.Close();
            string date_birth = $"{birth.Year}-{birth.Month}-{birth.Day}";
            command.CommandText = $"INSERT INTO `registration` (`phone_code`, `phone`, `name`, `surname`, `date_birth`, `password`, `code`) VALUES ({phone_code},{phone},'{name}','{surname}','{date_birth}','{password}','{$_code}')"



        }
        public void RegistrationConfirm(long phone, string code)
        {

        }
    }
}
