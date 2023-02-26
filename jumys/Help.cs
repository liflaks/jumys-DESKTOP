using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace Loader
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            change.ChangeForm("MainForm");
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            change.ChangeForm("Rezume");
            this.Hide();
        }

        

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var path = "C:\\Jumys\\session.txt";
            File.Delete(path);
            NewAuth newAuth = new NewAuth();
            newAuth.Show();
            this.Hide();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
