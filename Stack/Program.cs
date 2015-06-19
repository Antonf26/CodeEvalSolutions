using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        private static IntStack _intStack;
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
               outputStackInts(line);
            }
        }

        private static void outputStackInts(string line)
        {
            _intStack = new IntStack();
            //push the numbers after converting them
            foreach(int num in line.Split(' ').Select(num => Convert.ToInt32(num)))
            {
                _intStack.Push(num);
            }
            List<int> numbersToOutput = new List<int>();
            int i = 0;
            while(_intStack.Count > 0)
            {
                if(i % 2 == 0)
                {
                    numbersToOutput.Add(_intStack.Pop());
                }
                else
                {
                    _intStack.Pop();
                }
                i += 1;
            }
            Console.WriteLine(string.Join(" ", numbersToOutput.Select(num => num.ToString())));
        }
    }
    //Can use built-in c# stack structure, but that would be too easy
    interface IStack<T>
    {
        void Push(T obj);
        T Pop();
    }
    
    class IntStack: IStack<int>
    {
        private List<int> stack;

        public IntStack()
        {
            stack = new List<int>();
        }

        public void Push(int input)
        {
            stack.Add(input);
        }

        public int Pop()
        {
                int element = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return element;   
        }

        public int Count { get { return stack.Count; } }
    }
}
