using System;

namespace Endianness
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = BitConverter.IsLittleEndian ? "LittleEndian" : "BigEndian";
            Console.WriteLine(output);
        }
    }
}
