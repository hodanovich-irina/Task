using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChessLibrary
{
    public class Logger
    {
        private static string path = @"../../LoggerWrite.txt";
        public static void Write(string message)
        {
           
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(DateTime.Now.ToString() + " " + message);
            }
        }
    }
}
