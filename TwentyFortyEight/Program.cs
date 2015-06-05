using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFortyEight
{
    public static class GameLogic
    {
        private static int[,] board;
        private static int gridsize;
        private static string direction;


        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                processLine(line);
            }
        }

        private static void processLine(string line)
        {
            string[] values = line.Replace(" ", string.Empty).Split(';');
            direction = values[0];
            gridsize = Convert.ToInt32(values[1]);
            board = new int[gridsize, gridsize];
            char[] vals;
            string[] gridLines = values[2].Split('|');

            for(var i = 0; i < gridLines.Length; i++)
            {
                vals = gridLines[i].ToCharArray();
                for(var j = 0; j < gridLines.Length; j++)
                {
                    board[i, j] = (int)Char.GetNumericValue(vals[j]);
                }
            }
        }


        public static int[] processRow(int[] input)
        {
            var len = input.Length;
            for(var i = 0; i< input.Length -1; i++)
            {
                if(input[i] !=  0 && input[i] == input[i+1])
                {
                    input[i + 1] += input[i];
                    input[i] = 0;
                }
            }
            List<int> result = input.Where(x => x != 0).ToList<int>();

            while (result.Count != input.Length)
            {
                result.Insert(0, 0);
            }
            return result.ToArray();
        }




    }
}
