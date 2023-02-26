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
using System.IO;

namespace Loader
{
    public partial class NewAuth : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "/project.db";
        public NewAuth()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!CheckUser(email.Text, password.Text))
            {
                docker docker = new docker(email.Text, password.Text);
                try
                {
                    File.WriteAllText("C:\\Jumys\\session.txt", $"{email.Text} {password.Text}");
                }

                catch
                {
                    Directory.CreateDirectory("C:\\Jumys");
                    File.WriteAllText("C:\\Jumys\\session.txt", $"{email.Text} {password.Text}");
                }
                change.ChangeForm("MainForm");
                this.Hide();
            }

            else
            {
                status.Text = "Статус: Неверный пороль";
            }
        }

        private void RgstrBtn_Click(object sender, EventArgs e)
        {
            if (CheckUserEmail(email.Text))
            {
                if (email.Text != "" & password.Text != "")
                {
                    var con = new SQLiteConnection(cs);
                    con.Open();
                    string stm = $"INSERT INTO users (email, password) VALUES('{email.Text}', '{password.Text}')";
                    var cmd = new SQLiteCommand(stm, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    docker docker = new docker(email.Text, password.Text);
                    try
                    {
                        File.WriteAllText("C:\\Jumys\\session.txt", $"{email.Text} {password.Text}");
                    }
                    catch
                    {
                        Directory.CreateDirectory("C:\\Jumys");
                        File.WriteAllText("C:\\Jumys\\session.txt", $"{email.Text} {password.Text}");
                    }
                    NewAuthMore newAuthMore = new NewAuthMore();
                    this.Hide();
                    newAuthMore.Show();
                }

                else
                {
                    status.Text = "Статус: Проверьте свой пороль и логин";
                }
                
            }

            else if (!CheckUserEmail(email.Text))
            {
                status.Text = "Статус: Аккаунт уже существует! Войдите в него.";
            }
        }

        public bool CheckUser(string email, string password)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = $"SELECT email, password FROM users WHERE email = '{email}' AND password = '{password}'";
            var cmd = new SQLiteCommand(stm, con);
            if (cmd.ExecuteScalar() == null)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }

        private bool CheckUserEmail(string email)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = $"SELECT email, password FROM users WHERE email = '{email}'";
            var cmd = new SQLiteCommand(stm, con);
            if (cmd.ExecuteScalar() == null)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            password.Text = "";
        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            email.Text = "";
        }

        private void showPW_CheckedChanged(object sender, EventArgs e)
        {
            if(showPW.Checked)
            {
                password.UseSystemPasswordChar = false;
            }

            else
            {
                password.UseSystemPasswordChar = true;
            }
            
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
