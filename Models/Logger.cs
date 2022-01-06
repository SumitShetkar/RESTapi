using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Cricketer.Models
{
    public class Logger
    {
     
        public static void Log(string exceptionMessage)
        {
            FileStream stream;
            stream = new FileStream("Log.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(exceptionMessage+"  "+ DateTime.Now);
            writer.Flush();
            stream.Close();
        
        }
    }
}