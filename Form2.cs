using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegaty8983
{
    public partial class Komunikat : Form
    {
        private bool statIf;

        public Komunikat(string login)
        {
            InitializeComponent();
            Uzytkownik.Text = login;
            bool status = Lista.getInstance.ChckStatus(login);
            if (status)
            {
                Ranga.Text = "admin";
                statIf = true;
            }
            else
            {
                Ranga.Text = "not admin";
            }
        }

        private void Komunikat_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Creating_Click(object sender, EventArgs e)
        {
            if (statIf)
            {
                Hide();
                New_user okno3 = new New_user();
                okno3.Show();
            }
            else
            {
                Creating.Text = "You are not admin!";
            }
        }
    }
}
