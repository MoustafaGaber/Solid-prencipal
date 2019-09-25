using System;

namespace Solid_prencipal
{
    public class ConverterFactory
    {
        public static Converter Create(BaseType baseType, int decimalNumber)
        {
           
                try
                {
                    return (Converter)
                           Activator.CreateInstance(
                               Type.GetType($"Solid_prencipal.{baseType.ToString()}Converter"),
                               new object[] { decimalNumber });

                }
                catch (Exception)
                {

                return new InvalidBaseConverter(decimalNumber);
            }
            }
        }

}




