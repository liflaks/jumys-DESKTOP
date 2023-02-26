using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            change.ChangeForm("Rezume");
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            change.ChangeForm("Help");
            this.Hide();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            Vacasion vacasion = new Vacasion();
            vacasion.Show();
            this.Hide();
        }
    }
}
