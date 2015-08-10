using System;
using System.Collections.Generic;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                Console.WriteLine(getPascalTriangle(Convert.ToInt32(line)));
            }

            Console.ReadLine();
        }

        public static string getPascalTriangle(int depth)
        {
            List<String> triangleRows = new List<string>();
            for (var i = 0; i < depth; i++)
            {
                triangleRows.Add(getPascalRow(i));
            }
            return String.Join(" ", triangleRows);

        }

        public static string getPascalRow(int rowNumber)
        {
            int[] rowNumbers = new int[rowNumber + 1];
            rowNumbers[0] = 1;
            for (var i = 1; i <= rowNumber; i++)
            {
                rowNumbers[i] = (rowNumbers[i - 1] * (rowNumber + 1 - i)) / i;
            }
            return String.Join(" ", rowNumbers);
        }
    }
}
