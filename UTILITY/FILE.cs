using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.UTILITY
{
    public static class FILE
    {
        static string _path = @"test";
        public static void write(string data)
        {
            StreamWriter file = 
                new StreamWriter(_path, true, Encoding.GetEncoding("utf-8"));

            file.WriteLine(data);
            file.Close();
        }

        public static void write(string path, List<string> data, bool append = true)
        {
            StreamWriter file =
                new StreamWriter(path, append, Encoding.GetEncoding("utf-8"));

            foreach (string s in data)
            {
                file.WriteLine(s);
            }
            file.Close();
        }

        public static List<string> read(string path)
        {
            try
            {
                StreamReader file = new StreamReader(path);
                List<string> datas = new List<string>();
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    datas.Add(line);
                }
                file.Close();
                return datas;
            }
            catch
            {
                return null;
            }
        }
    }
}
