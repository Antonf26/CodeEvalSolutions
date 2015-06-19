using System;
using System.Linq;

namespace FirstNonRepeating
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                Console.WriteLine(findFirstNonRepeated(line));
            }
        }

        private static char findFirstNonRepeated(string line)
        {
            return line.Where(x => line.Count(y => y == x) == 1).First();
        }
    }
}
