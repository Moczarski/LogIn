using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty8983
{
    [Serializable()]
    public class User
    {
        public string IDUser;
        public string Login;
        public string Passw;
        public bool IsAdmin;

        public User(string ID, string Login_user, string Passw_user, bool IsAdmin_user)
        {
            IDUser = ID;
            Login = Login_user;
            Passw = Passw_user;
            IsAdmin = IsAdmin_user;
            // haslo dla innych userow to "haslo"
        }  

        public bool ChckPass(string password_box, string ID)
        {
            byte[] salt = Encoding.ASCII.GetBytes(ID + "8983Moczarski");
            Rfc2898DeriveBytes encoded_psw = new Rfc2898DeriveBytes(password_box, salt);
            string PassToChck = Encoding.ASCII.GetString(encoded_psw.GetBytes(salt.Length));

            if (PassToChck == Passw)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
