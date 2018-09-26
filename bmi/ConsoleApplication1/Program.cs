using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Please enter your weight in kg");
            int w = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your height in m");
            int h = int.Parse(Console.ReadLine());
            int bmiResult = bmi(w, h);
            Console.WriteLine($"your bmi is ={ bmi(w, h)}");
            Console.WriteLine($" {categories(bmiResult)}");

            Console.ReadLine();

        }
        static public int bmi(int w, int h)
        {
            int bmi = w / (h * h);
            return bmi;
        }




        public static string categories(int bmi)

        {

            string bmic = "";
            if (bmi < 18.5)
            {
                bmic = "your bmi is underweight";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                bmic = "your bmi is noprmalWeight";
            }
            else if (bmi >= 25 && bmi < 30)

            {
                bmic = "your bmi is overweight";
            }
            else if (bmi >= 30)
            {
                bmic = "your bmi is obses";
            }


            return bmic;

        }


    }
}
