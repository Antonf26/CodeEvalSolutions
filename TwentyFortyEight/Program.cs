using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyFortyEight
{
    public static class GameLogic
    {
        private static int[][] board;
        private static int gridsize;
        private static string direction;


        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
                Console.WriteLine(processLine(line));
            }
            Console.ReadLine();
        }

        public static string processLine(string line)
        {
            string[] values = line.Split(';');
            direction = values[0];
            gridsize = Convert.ToInt32(values[1]);
            board = new int[gridsize][];
            
            string[] gridLines = values[2].Split('|');

            for (var i = 0; i < gridLines.Length; i++)
            {
                board[i] = Array.ConvertAll(gridLines[i].Trim().Split(' '), numStr => Convert.ToInt32(numStr) );
            }

            switch (direction)
            {
                case "RIGHT":
                    for (var i = 0; i < board.Length; i++)
                    {
                        board[i] = processRow(board[i]);
                    }
                    break;
                case "LEFT":
                    for (var i = 0; i < board.Length; i++)
                    {
                        Array.Reverse(board[i]);
                        board[i] = processRow(board[i]);
                        Array.Reverse(board[i]);
                    }
                    break;
                case "DOWN":
                    for (var i = 0; i < board.Length; i++)
                    {
                        writeColumn(processRow(getColumn(i)), i);
                    }
                    break;
                case "UP":
                    for (var i = 0; i < board.Length; i++)
                    {
                        int[] col = getColumn(i);
                        Array.Reverse(col);
                        col = processRow(col);
                        Array.Reverse(col);
                        writeColumn(col, i);
                    }
                    break;
                default:
                    break;
            }
            return string.Join("|", board.Select(
                row => string.Join(" ", Array.ConvertAll(row, num => num.ToString()))).ToArray());
        }


        public static int[] processRow(int[] input)
        {
            var len = input.Length;
            input = input.Where(x => x != 0).ToArray();
            for (var i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != 0 && input[i] == input[i + 1])
                {
                    input[i + 1] += input[i];
                    input[i] = 0;
                    i += 1; 
                }
            }
            List<int> result = input.Where(x => x != 0).ToList<int>();

            while (result.Count != len)
            {
                result.Insert(0, 0);
            }
            return result.ToArray();
        }

        public static int[] getColumn(int index)
        {
            int[] res = new int[gridsize];
            for (var i = 0; i < res.Length; i++)
            {
                res[i] = board[i][index];
            }
            return res;
        }

        public static void writeColumn(int[] column, int index)
        {
            for (var i = 0; i < column.Length; i++)
            {
                board[i][index] = column[i];
            }
        }




    }
}
