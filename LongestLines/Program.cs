using System;
using System.Linq;

namespace LongestLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach(string line in fileLines.Skip(1).OrderByDescending(x => x.Length).Take(Convert.ToInt32(fileLines[0])))
            {
                Console.WriteLine(line);
            }
        }
    }
}
