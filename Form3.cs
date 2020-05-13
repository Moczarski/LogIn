using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegaty8983
{
    public partial class New_user : Form
    {

        private delegate void ModifyUser();
        ModifyUser MU;

        public New_user()
        {
            InitializeComponent();
            MU = RefreshList;
            MU.Invoke();
        }

        public void RefreshList()
        {
            if (File.Exists("MM8983.bin"))
            {
                using (Stream checking = File.Open("MM8983.bin", FileMode.Open))
                {
                    BinaryFormatter database = new BinaryFormatter();
                    var list = (List<User>)database.Deserialize(checking);
                    Lista.getInstance.ListedUsers(list);
                    users_box.Items.Clear();
                    MU = ListToString;
                    MU.Invoke();
                }
            }
        }

       private void ListToString()
        {
            string ID;
            string login;
            string passw;
            string status;
            string list = "";
            int i = 1;
            list = "Nr___ID___Login___Hasło___Status";
            users_box.Items.Add(list);
            foreach (User user in Lista.getInstance.database)
            {
                ID = user.IDUser.ToString();
                login = user.Login;
                passw = user.Passw;
                status = user.IsAdmin.ToString();
                list = i.ToString() + ". " + ID + " " + login + " " + passw + " " + status;
                users_box.Items.Add(list);
                i++;
            }
        }

        private void Manager_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MU = LetsClean;
            MU.Invoke();
        }

        private void LetsClean()
        {
            New_login.Text = "";
            New_password.Text = "";
            Create_admin.Checked = false;
        }

        private void Create_NewUser_Click(object sender, EventArgs e)
        {
            MU = NewUser;
            MU.Invoke();
        }

        private void NewUser()
        {
            bool status = Lista.getInstance.ChckLogin(New_login.Text);

            if (status)
            {
                Login_exist.Text = "Login już istnieje!!";
                New_login.Text = "";
            }
            else if (New_login.Text.Equals("") || New_password.Text.Equals(""))
            {
                Login_exist.Text = "Pola nie mogą być puste!";
            }
            else
            {
                Lista.getInstance.NewUser(New_login.Text, New_password.Text, Create_admin.Checked);
                Lista.getInstance.CheckDatabase();
                MU = RefreshList;
                MU.Invoke();
                Login_exist.Text = "Utworzono użytkownika " + New_login.Text + "!";
            }
        }

        private void Delete_user_Click(object sender, EventArgs e)
        {
            MU = DeleteUser;
            MU.Invoke();
        }

        private void DeleteUser()
        {
            bool status = Lista.getInstance.ChckLogin(New_login.Text);

            if (status)
            {
                Lista.getInstance.DelUser(New_login.Text);
                Lista.getInstance.CheckDatabase();
                MU = RefreshList;
                MU.Invoke();
                Login_exist.Text = "Usunięto użytkownika " + New_login.Text + "!";
            }
            else if (New_login.Text.Equals(""))
            {
                Login_exist.Text = "Podaj nazwę użytkownika!";
            }
            else
            {
                Login_exist.Text = "Wpisz istniejący login!";
            }
        }
    }
}
