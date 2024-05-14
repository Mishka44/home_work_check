using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace home_work_check
{
    internal class FileID
    {
        public static void WriteToFile(string path, string content, bool append = true)
        {
           
                /*StreamWriter sw = new StreamWriter(path, append);
                sw.WriteLine(content);
                sw.Close();*/
                using (StreamWriter sw2 = new StreamWriter(path, append))
                {
                    sw2.WriteLine(content);
                }

            
        }
        public static string ReadFromFile(string path)
        {
            string result = "";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    result = sr.ReadToEnd();
                }
            }
            return result;
        }
    }
}
