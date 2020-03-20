using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    public class User
    {
        //public bool Registered {  get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PassHash { get; set; }
        public int ID { get;  set; }
        private static readonly string salt = "gneog$73n#dj";

        public User()
        {
        }

        public User (string email, string password)
        {
            PassHash = GetHash(password, salt);
            Email = email;
        }

        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PassHash = GetHash(password, salt);
        }

        public bool RightPass(string pass)
        {
            return this.PassHash == GetHash(pass, salt);
        }
        static string GetHash(string password, string salt) //Получение хэш-значения
        {
            MD5 md5 = new MD5CryptoServiceProvider(); //Экземпляр объекта MD5
            byte[] digest = md5.ComputeHash(Encoding.UTF8.GetBytes(password + salt)); //Вычисление хэш-значения
            string base64digest = Convert.ToBase64String(digest, 0, digest.Length); //Получение строкового значения из массива байт
            return base64digest;
        }
    }
}
