using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
    internal class change
    {
        public static void ChangeForm(string name)
        {
            if (name == "MainForm")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }

            else if (name == "Help")
            {
                Help help = new Help();
                help.Show();
            }

            else if (name == "Rezume")
            {
                Rezume rezume = new Rezume();
                rezume.Show();
            }
        }
    }
}
