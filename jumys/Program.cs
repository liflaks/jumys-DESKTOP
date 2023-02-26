 using Loader;
using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;



namespace KeyAuth
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var path = "C:\\Jumys\\session.txt";
            var exist = File.Exists(path);
            if (exist)
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] t_line = line.Split(' ');
                        if (!new NewAuth().CheckUser(t_line[0], t_line[1]))
                        {
                            Application.Run(new MainForm());
                        }

                        else
                        {
                            Application.Run(new NewAuth());
                        }
                    }
                    
                    sr.Close();
                }
            }

            else
            {
                Application.Run(new NewAuth());
            }
            
        }
    }
}
