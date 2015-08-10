using System;
using System.Linq;

namespace ArrayAbsurdity
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                ProcessAbsurdArrayLine(line);
            }
            
        }

        private static void ProcessAbsurdArrayLine(string line)
        {
            int[] absurdArray = line.Substring(line.IndexOf(';') + 1).Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            int duplicate = FindDuplicateInAbsurdArray(absurdArray);
            Console.WriteLine(duplicate);

        }

        private static int FindDuplicateInAbsurdArray(int[] absurdArray)
        {
            bool[] possibles = new bool[absurdArray.Length - 1];
            foreach(int i in absurdArray)
            {
                if(possibles[i])
                {
                    return i;
                }
                possibles[i] = true;
            }
            return 0;
        }
    }
}
