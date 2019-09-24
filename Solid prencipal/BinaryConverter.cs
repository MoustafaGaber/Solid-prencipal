namespace Solid_prencipal
{
    public class BinaryConverter : Converter
    {
        public BinaryConverter(int decimalNumber)
            : base(decimalNumber)
        {

        }
        public override string Convert()
        {
            return $"The result is: {System.Convert.ToString(DecimalNumber, 2)}";
        }
    }
}




