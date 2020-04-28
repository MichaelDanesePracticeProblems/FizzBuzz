using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {//Will accept two arguments, test if they are viable, test if they are ordered correctly and will reorder them if not, and run the FizzBuzz game.
            int min;
            int max;
            if (args.Length == 2 && int.TryParse(args[0], out min) && int.TryParse(args[1], out max))
            {//Tests in order: Tests if there were 2 arguments passed, tests if these arguments are numbers, and if so sets min and max to the params. 

                if (min > max)
                {//Switches params order if the min is larger than the max
                    int temp = min;
                    min = max;
                    max = temp;
                }
            }
            else
            {
                min = 0;
                max = 100;
            }
            for (int i = min; i < max; i++)
            {
                bool threeDivIsTrue = (i % 3 == 0);
                bool fiveDivIsTrue = (i % 5 == 0);
                if (threeDivIsTrue && fiveDivIsTrue)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDivIsTrue)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDivIsTrue)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
