using System;

namespace looooops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prompter");
            Console.WriteLine("");
            Console.WriteLine("Enter minimum value:");
            bool valid = int.TryParse(Console.ReadLine(), out int min);
            while (!valid)
            {
                Console.WriteLine("Error: please enter a number.");
                valid = int.TryParse(Console.ReadLine(), out min);
            }
            Console.WriteLine("Enter maximum value:");
            valid = int.TryParse(Console.ReadLine(), out int max);
            while (!valid)
            {
                Console.WriteLine("Error: please enter a number.");
                valid = int.TryParse(Console.ReadLine(), out max);
            }
            int num;
            do
            {
                Console.WriteLine($"Please enter a number between {min} and {max}.");
                int.TryParse(Console.ReadLine(), out num);
            } while ((num < min) || (num > max));
            Console.WriteLine("Thank you.");
            Console.WriteLine("");


            Console.WriteLine("PercentPassing");
            Console.WriteLine("");
            bool done = false;
            double studentCount = 0;
            double passCount = 0;
            do
            {
                Console.WriteLine("Input student's grade. Type \"done\" to finish.");
                string score = Console.ReadLine();
                if (score == "done")
                {
                    done = true;
                }
                else if (int.TryParse(score, out int grade))
                {
                    studentCount += 1;
                    if (grade >= 70)
                    {
                        passCount += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            } while (!done);
            double percentPassed = passCount / studentCount * 100;
            Console.WriteLine($"{Math.Round(percentPassed, 2)}% of your students passed.");
            Console.WriteLine("");


            Console.WriteLine("OddSum");
            Console.WriteLine("");
            int end = 0;
            valid = false;
            int total = 0;
            while (!valid)
            {
                Console.WriteLine("Please enter a number.");
                valid = int.TryParse(Console.ReadLine(), out end);
            }
            for (int i = 1; i <= end; i += 2)
            {
                total += i;
            }
            Console.WriteLine($"{total} is the sum of all odd numbers up to {end}.");
            Console.WriteLine("");


            Console.WriteLine("RandomNumbers");
            Console.WriteLine("");
            Console.WriteLine("Enter minimum value:");
            valid = int.TryParse(Console.ReadLine(), out min);
            while (!valid)
            {
                Console.WriteLine("Error: please enter a number.");
                valid = int.TryParse(Console.ReadLine(), out min);
            }
            Console.WriteLine("Enter maximum value:");
            valid = int.TryParse(Console.ReadLine(), out max);
            while (!valid)
            {
                Console.WriteLine("Error: please enter a number.");
                valid = int.TryParse(Console.ReadLine(), out max);
            }
            Random gen = new Random();
            for (int i = 1; i <=25; i++)
            {
                Console.WriteLine(gen.Next(min, max + 1));
            }
        }
    }
}
