using System;
using System.Collections.Generic;
using System.Linq;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                Console.WriteLine(PangramChecker.getMissingLetters(line));   
            }
        }
    }

    public static class PangramChecker
    {
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public static string getMissingLetters(string line)
        {
            var missingLetters = missingLettersInString(line);
            return missingLetters.Count() == 0 ? "NULL" : String.Join(null, missingLetters);
        }

        private static IEnumerable<char> missingLettersInString(string PotentialPangram)
        {
            return alphabet.Except(PotentialPangram.ToLower());
        }
    }
}
