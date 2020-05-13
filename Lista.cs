using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty8983
{
    public class Lista
    {

        public List<User> database = new List<User>()
        {
            new User("ADMIN", "Mateusz", GetPassw(), true)
        };

        private static string GetPassw()
        {
            byte[] salt = Encoding.ASCII.GetBytes("ADMIN" + "8983Moczarski");
            Rfc2898DeriveBytes encoded_psw = new Rfc2898DeriveBytes("Moczarski", salt);
            string adminPassw = Encoding.ASCII.GetString(encoded_psw.GetBytes(salt.Length));
            return adminPassw;
        }

        private static Lista instance = new Lista();

        public static Lista getInstance
        {
            get
            {
                return instance;
            }
        }

        public void NewUser(string login, string password, bool IsAdmin)
        {
            string ID = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            //int ID = database.Count + 1;
            byte[] salt = Encoding.ASCII.GetBytes(ID + "8983Moczarski");
            Rfc2898DeriveBytes encoded_psw = new Rfc2898DeriveBytes(password, salt);
            string newPassw = Encoding.ASCII.GetString(encoded_psw.GetBytes(salt.Length));
            database.Add(new User(ID, login, newPassw, IsAdmin));
        }

        public void DelUser(string login)
        {
            User test = database.Single(x => x.Login == login);
            database.Remove(test);
        }


        public bool Checking(string Login_form, string Passw_form)
        {
            foreach (User user in database)
            {
                if (user.Login == Login_form)
                {
                    if (user.ChckPass(Passw_form, user.IDUser))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ChckLogin(string login)
        {
            string ChckThatLogin = login;
            foreach (User user in database)
            {
                if (user.Login == ChckThatLogin)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ChckStatus(string status_byLogin)
        {
            User status = database.Find(x => x.Login == status_byLogin);
            return status.IsAdmin;
        }

        public void CheckDatabase()
        {
            using (Stream update = File.Open("MM8983.bin", FileMode.OpenOrCreate))
            {
                BinaryFormatter database = new BinaryFormatter();
                database.Serialize(update, this.database);
            }
        }

        public void ListedUsers(List<User> list)
        {
            database = list;
        }
    }
}
