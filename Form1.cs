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
    public partial class Logowanie : Form
    {
        public string password;
        public string login;

        public Logowanie()
        {
            InitializeComponent();
            if (File.Exists("MM8983.bin"))
            {
                using (Stream checking = File.Open("MM8983.bin", FileMode.Open))
                {
                    BinaryFormatter database = new BinaryFormatter();
                    var list = (List<User>)database.Deserialize(checking);
                    Lista.getInstance.ListedUsers(list);
                }
            }
            else
            {
                Lista.getInstance.CheckDatabase();
            }
        }

        private void Zaloguj_Click(object sender, EventArgs e)
        {
            password = Haslo_box.Text;
            login = Login_box.Text;
            bool score = Lista.getInstance.Checking(login, password);
            if (!score)
            {
                In_psw.Text = "password is incorrect";
                Haslo_box.Text = "";
            }
            else
            {
                Hide();
                Komunikat okno2 = new Komunikat(login);
                okno2.Show();
            }
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
