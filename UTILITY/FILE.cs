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

        public static void write(string path, List<string> data)
        {
            StreamWriter file =
                new StreamWriter(path, true, Encoding.GetEncoding("utf-8"));

            foreach (string s in data)
            {
                file.WriteLine(s);
            }
            file.Close();
        }
    }
}
