using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionD
{
    class Program3a
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int magicNum = rnd.Next(1, 9);
            int guess, count=0;

            do
            {
                count++;
                Console.Write("Please enter your guess number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if(magicNum == guess)
                {
                    Console.WriteLine("Congratulations! It took you {0} attempts!", count);
                }
            } while (magicNum != guess);
           
        }
    }
}
