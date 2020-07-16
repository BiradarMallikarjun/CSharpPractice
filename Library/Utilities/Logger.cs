using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Library.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {            
                File.AppendAllText(@".\Logs.txt", message+"\n");
        }
    }
}
