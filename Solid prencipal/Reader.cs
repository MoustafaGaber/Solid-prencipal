using System;

namespace Solid_prencipal
{
    public class Reader:IReader
    {
        public int ReadInteger()
        {
            return int.Parse(Console.ReadLine());
        }
    }

 }




