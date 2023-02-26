using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loader
{
    public class docker
    {
        public static string emailData;
        public static string passwordData;
        public docker(string emailString, string passwordString)
        {
            emailData= emailString;
            passwordData= passwordString;
        }

        public static void getPass()
        {
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
                        emailData = t_line[0];
                        passwordData = t_line[1];
                    }
                    sr.Close();
                }
            }
        }
    }
}
