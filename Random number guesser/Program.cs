using System;

namespace Random_number_guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            var correct = Convert.ToInt32(new Random().Next(1, 10));
            Console.WriteLine(correct);
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Type in a digit between (and including) 1-10: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (i == 3)
                {
                    Console.WriteLine("You failed :(");
                    break;
                }
                if (input == correct)
                {
                    Console.WriteLine("You are correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }

        }
    }
}
