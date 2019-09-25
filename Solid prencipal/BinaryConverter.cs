using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid_prencipal
{
    public class BinaryConverter : Converter, IBinaryConverter
    {
        public BinaryConverter(int decimalNumber)
            : base(decimalNumber)
        {

        }

        public string BinaryToText(string binaryNumber)
        {
            binaryNumber = binaryNumber.Replace(" ", "");

            var list = new List<Byte>();

            for (int i = 0; i < binaryNumber.Length; i += 8)
            {
                String t = binaryNumber.Substring(i, 8);

                list.Add(System.Convert.ToByte(t, 2));
            }

            var result = list.ToArray();

            return Encoding.ASCII.GetString(result);
        }

        public override string Convert()
        {
            return $"The result is: {System.Convert.ToString(DecimalNumber, 2)}";
        }

        public string TextToBinary(string text)
        {

            var bytes = Encoding.ASCII.GetBytes(text);

            return string.Join(" ",
                bytes.Select(byt => System.Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
    }

        

        
   
}




