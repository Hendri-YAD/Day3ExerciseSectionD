using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionD
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 88)
            {                
                Console.Write("Please enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 88)
                {
                    Console.WriteLine("Lucky you...");
                }
            }

        }
    }
}
