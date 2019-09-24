using System;

namespace Solid_prencipal
{

    public enum BaseType
    {
        Binary = 2,
        Octal = 8,
        Hexadecimal=16,
        None = 0
    }
    public class NumberConverter
    {
        public int DecimalNumber { get; set; }

        public Logger Logger { get; set; } = new Logger();
        public Reader Reader { get; set; } = new Reader();


        public void Convert()
        {
            //Console.WriteLine("Program is starting...");
            Logger.Log("Program is starting...");

            //Console.WriteLine("Enter the number to convert:");
            Logger.Log("Enter the number to convert:");
            DecimalNumber = Reader.ReadInteger();//int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the base type (Ex: 2,8):");
            Logger.Log("Enter the base type (Ex: 2,8,16):");

            //var baseType = (BaseType)int.Parse(Console.ReadLine());//

            var baseType = (BaseType)Reader.ReadInteger();

            string result = String.Empty;
            //befor ocp 
            /*switch (baseType)
            {
                case BaseType.Binary:
                    result = System.Convert.ToString(DecimalNumber, 2);
                    break;

                case BaseType.Octal:
                    result = System.Convert.ToString(DecimalNumber, 8);
                    break;

                default:
                    result = "No base found!";
                    break;
            } */
            //قبل المبدأ الثالث

            /* switch (baseType)
             {
                 case BaseType.Binary:
                     var binaryConverter = new BinaryConverter(DecimalNumber);
                     result = binaryConverter.Convert();
                     break;

                 case BaseType.Octal:
                     var octalConverter = new OctalConverter(DecimalNumber);
                     result = octalConverter.Convert();
                     break;

                 case BaseType.Hexadecimal:
                     var hexadecimalConverter = new HexadecimalConverter(DecimalNumber);
                     result = hexadecimalConverter.Convert();

                     break;

                 default:
                     result = "No base found!";
                     break;
             }*/


            var type = ConverterFactory.Create(baseType, DecimalNumber);

             result = type.Convert();

            // Console.WriteLine($"The result is: {result} ");

            Logger.Log($"The result is: {result} ");


            //Console.WriteLine("Program is ending..");
            Logger.Log("Program is ending..");

        }

    }

 }




