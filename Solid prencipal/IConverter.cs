namespace Solid_prencipal
{
    public interface IConverter
    {
        string BinaryToText(string binary);
        string TextToBinary(string text);
        string HexadecimalToText(string text);
        string TextToHexadecimal(string text);
    }
}




