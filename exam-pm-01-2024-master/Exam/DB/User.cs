using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DB
{
    internal class User
    {
        public int id { get; set; }
        public string? login { get; set; }
        public string? email { get; set; }
        public string? name { get; set; }
        /**
         * if user admin -> group_id: 1
         * if user user -> group_id: 2
         */
        public int group { get; set; }

        private string _password = "";
        public string password
        {
            get => _password;
            set => this._password = CreateHashPassword(value);
        }

        public static string CreateHashPassword(string input)
        {
            MD5 MD5Hash = MD5.Create(); //создаем объект для работы с MD5
            byte[] inputBytes = Encoding.ASCII.GetBytes(input); //преобразуем строку в массив байтов
            byte[] hash = MD5Hash.ComputeHash(inputBytes); //получаем хэш в виде массива байтов        

            return Convert.ToHexString(hash);

        }
    }
}
