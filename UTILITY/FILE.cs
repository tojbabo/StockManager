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
        static string path = @"test";
        public static void write(string data)
        {
            StreamWriter file = 
                new StreamWriter(path, true, Encoding.GetEncoding("utf-8"));

            file.WriteLine(data);
            file.Close();
        }
    }
}
