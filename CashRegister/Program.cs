using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = System.IO.File.ReadAllLines(args[0]);
            foreach (string line in fileLines)
            {
              Console.WriteLine(ProcessRegisterInputLine(line));
            }
            Console.ReadLine();
        }

        static string ProcessRegisterInputLine(string line)
        {
            string[] inputs = line.Split(';');
            decimal price = Convert.ToDecimal(inputs[0]);
            decimal cash = Convert.ToDecimal(inputs[1]);
            return Register.GetChangeString(price, cash);
        }
    }

    public static class Register
    {
        private static Denomination[] AvailableDenominations = new Denomination[12];

        static Register()
        {
            
            AvailableDenominations[11] = new Denomination("PENNY", 1);
            AvailableDenominations[10] = new Denomination("NICKEL", 5);
            AvailableDenominations[9] = new Denomination("DIME", 10);
            AvailableDenominations[8] = new Denomination("QUARTER", 25);
            AvailableDenominations[7] = new Denomination("HALF DOLLAR", 50);
            AvailableDenominations[6] = new Denomination("ONE", 100);
            AvailableDenominations[5] = new Denomination("TWO", 200);
            AvailableDenominations[4] = new Denomination("FIVE", 500);
            AvailableDenominations[3] = new Denomination("TEN", 1000);
            AvailableDenominations[2] = new Denomination("TWENTY", 2000);
            AvailableDenominations[1] = new Denomination("FIFTY", 5000);
            AvailableDenominations[0] = new Denomination("ONE HUNDRED", 10000);

        }


        public static string GetChangeString(decimal price, decimal cashGiven)
        {
            if (price.Equals(cashGiven))
            {
                return "ZERO";
            }
            if(price > cashGiven)
            {
                return "ERROR";
            }
            List<string> ChangeDenominations = new List<string>();
            int penniesChange = Convert.ToInt32((cashGiven - price) * 100);
            int i = 0;
            while(penniesChange > 0)
            {
                if(penniesChange / AvailableDenominations[i].value > 0)
                {
                    ChangeDenominations.Add(AvailableDenominations[i].name);
                    penniesChange -= AvailableDenominations[i].value;
                }
                else
                {
                    i += 1;
                }
            }
            return String.Join(",", ChangeDenominations);
        }

    }

    public struct Denomination
    {
        public string name;
        public int value;
       

        public Denomination(string Name, int Value)
        {
            
            this.name = Name;
            this.value = Value;
        }
    }


}
