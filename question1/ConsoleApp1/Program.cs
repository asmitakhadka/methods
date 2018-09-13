using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The input (number) chnaged i.e {ChangeSign(number)}");
        }
        public static int ChangeSign(int number)
        {
            return number *- 1;
        }
    }
}
