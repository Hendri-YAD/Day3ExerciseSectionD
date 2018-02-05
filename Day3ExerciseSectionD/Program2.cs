using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionD
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers: ");
            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());        

            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int larger, smaller;

            if (a > b)
            { 
                larger = a;
                smaller = b;
            }
            else if (b > a)
            { 
                larger = b;
                smaller = a;
            }
            else
            {
                larger = a;
                smaller = b;
            }

            while (larger != smaller)
            {
                larger = larger - smaller;
                if (smaller > larger)
                {
                    int temp = larger;
                    larger = smaller;
                    smaller = temp;
                }
            }

            int hcf = larger;
            int lcm = (a * b) / hcf;

            Console.WriteLine("HCF is {0}. LCM is {1}.", hcf, lcm);
        }
    }
}
