﻿using System.IO;

namespace Solid_prencipal
{
    public class TextFileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter writer = File.AppendText("logFile.txt"))
            {
                writer.WriteLine(message);
            }
        }
    }

}




