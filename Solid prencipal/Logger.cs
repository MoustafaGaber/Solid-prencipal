﻿using System;

namespace Solid_prencipal
{
    public class Logger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

}




