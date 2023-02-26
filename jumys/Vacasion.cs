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
    public partial class Vacasion : Form
    {
        public Vacasion()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            change.ChangeForm("MainForm");
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
