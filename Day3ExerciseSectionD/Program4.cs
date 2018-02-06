using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionD
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double G;

            Random rnd = new Random();
            G = rnd.NextDouble() * (num - 1) + 1;

            if (num == 0)
            {
                G = 0;
                Console.WriteLine("The square root of {0} is {1:0.000}", num, G);
                return;
            }

            while (Math.Abs((G*G) - num) >= 0.0001)
            {
                G = (G + (num / G)) / 2;
            }           

            Console.WriteLine("The square root of {0} is {1:0.###}", num, G);

        }
    }
}
