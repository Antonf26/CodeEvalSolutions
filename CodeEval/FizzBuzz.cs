using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                outputFizzBuzzForLine(line);
            }
        }

        private static void outputFizzBuzzForLine(string line)
        {
            List<string> results = new List<string>();
            string[] values = line.Split(' ');
            int x = Convert.ToInt16(values[0]);
            int y = Convert.ToInt16(values[1]);
            int N = Convert.ToInt16(values[2]);
            for(var i = 1; i <= N; i++)
            {
                results.Add(getFizzBuzzValue(x, y, i));
            }
            Console.WriteLine(string.Join(" ", results));
        }

        private static string getFizzBuzzValue(int x, int y, int num)
        {
            if(num % y == 0 && num % x == 0)
            {
                return "FB";
            }
            if(num % x == 0)
            {
                return "F";
            }
            if(num % y == 0)
            {
                return "B";
            }
            return num.ToString();

        }
    }
}
