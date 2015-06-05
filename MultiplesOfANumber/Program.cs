using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                outputLowestMultipleForLine(line);
            }
        }

        private static void outputLowestMultipleForLine(string line)
        {
            throw new NotImplementedException();
        }
        private static int getLowestMultipleEqualToOrOver(int x, int n)
        {
            return 0;

        }

    }
}
