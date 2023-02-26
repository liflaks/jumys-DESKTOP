using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Loader
{
    public partial class NewAuthMore : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "/project.db";
        public NewAuthMore()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = $"UPDATE users SET phone = '{PhoneNumber.Text}', citizenship = '{CitizenShip.Text}', birthDate = '{BirthDate.Text}', expirience = '{Skills.Text}', iin = '{IIN.Text}', fio = '{FIO.Text}' WHERE email = '{docker.emailData}'";
            var cmd = new SQLiteCommand(stm, con);
            cmd.ExecuteNonQuery();
            con.Close();
            change.ChangeForm("MainForm");
            this.Hide();
        }

        private void FIO_Click(object sender, EventArgs e)
        {
            FIO.Text = "";
        }

        private void IIN_Click(object sender, EventArgs e)
        {
            IIN.Text = "";
        }

        private void PhoneNumber_Click(object sender, EventArgs e)
        {
            PhoneNumber.Text = "";
        }

        private void CitizenShip_Click(object sender, EventArgs e)
        {
            CitizenShip.Text = "";
        }

        private void BirthDate_Click(object sender, EventArgs e)
        {
            BirthDate.Text = "";
        }

        private void Skills_Click(object sender, EventArgs e)
        {
            Skills.Text = "";
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
