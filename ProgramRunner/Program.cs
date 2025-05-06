using System;
using OldPhonePadDecoder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("OldPhonePad Decoder\n");

        string[] examples =
        {
            "33#",
            "227*#",
            "4433555 555666#",
            "8 88777444666*664#"
        };

        foreach (var input in examples)
        {
            string result = OldPhonePad.Decode(input);
            Console.WriteLine($"Input: \"{input}\" => Output: \"{result}\"");
        }
    }
}
