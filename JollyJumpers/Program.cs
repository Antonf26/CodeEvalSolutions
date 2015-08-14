using System;
using System.Linq;

namespace JollyJumpers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                string output = JollyJumperChecker.isJollyJumper(line.Split(' ').Select(x => Convert.ToInt32(x)).ToArray()) ?
                    "Jolly" : "Not jolly";
                Console.WriteLine(output);
            }
        }
    }

    public static class JollyJumperChecker
    {
        public static bool isJollyJumper(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return true;
            }
            bool[] differences = new bool[numbers.Length -1];
            
            for(var i = 0; i < numbers.Length -1; i++)
            {
                var diff = Math.Abs(numbers[i] - numbers[i + 1]);
                if(diff <= differences.Length && diff != 0)
                {
                    differences[diff - 1] = true;
                }
            }
            return !(differences.Contains(false));
        }
    }
}
