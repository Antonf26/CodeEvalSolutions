using System;
using System.Linq;
using ExtensionMethods;

namespace NumberOfOnes
{
    //using public to allow unit testing
    public static class NumberOfOnesGetter
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                Console.WriteLine(Convert.ToInt32(line).NumberOfOnes());
            }
        }
    }
}
//Realise this may be overkill - just playing about with extension methods
namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static int NumberOfOnes(this int x)
        {
            return Convert.ToString(x, 2).Count(ch => ch == '1');
        }
    }
}
