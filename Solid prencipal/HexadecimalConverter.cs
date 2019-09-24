namespace Solid_prencipal
{
    public class HexadecimalConverter : Converter
    {
        public HexadecimalConverter(int decimalNumber) : base(decimalNumber)
        {
        }

        public override string Convert()
        {
            return $"The result is: {DecimalNumber.ToString("X")}";
        }
    }

 }




