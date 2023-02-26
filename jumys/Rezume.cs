using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Loader
{
    public partial class Rezume : Form
    {
        SQLiteDataReader dr;
        string cs = @"URI=file:" + Application.StartupPath + "/project.db";
        public Rezume()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            change.ChangeForm("MainForm");
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            change.ChangeForm("Help");
            this.Hide();
        }

        private void Rezume_Load(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            docker.getPass();
            string stm = $"SELECT * FROM users WHERE email = {docker.emailData}";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                phoneNubmer.Text = dr.GetString(3);
                citizenship.Text = dr.GetString(4);
                birthDate.Text = dr.GetString(5);
                skills.Text = dr.GetString(6);
                iin.Text = "ИИН: " + dr.GetString(7);
                fio.Text = dr.GetString(8);
            }
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
        }
    }
}
