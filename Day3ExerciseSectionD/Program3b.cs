using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionD
{
    class Program3b
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
                if (magicNum == guess && count == 1)
                {
                    Console.WriteLine("You are a Wizard! It took you {0} attempt!", count);
                }
                else if (magicNum == guess && count <= 2)
                {
                    Console.WriteLine("You are a Wizard! It took you {0} attempts!", count);
                }
                else if (magicNum == guess && count <= 3)
                {
                    Console.WriteLine("You are a good guess! It took you {0} attempts!", count);
                }
                else if (magicNum != guess)
                {
                    Console.WriteLine("You are lousy! Try again!");
                }
                else
                {
                    Console.WriteLine("Congratulations! It took you {0} attempts!", count);
                }
            } while (magicNum != guess);
           
        }
    }
}
