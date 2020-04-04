using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many coin flips do you want to conduct? ");
            int numCoinFlips = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int numHeads = 0;
            int numTails = 0;

            for (int i = 0; i < numCoinFlips; i++)
            {
                int rand_result = rand.Next(0,2);
                string flip_result = "";

                if (rand_result == 0)
                {
                    flip_result = "heads";
                    numHeads += 1;
                }
                else
                {
                    flip_result = "tails";
                    numTails += 1;
                }
                Console.WriteLine($"Flip {i+1}: ... Result is: {flip_result}");
            }

            Console.WriteLine($"A total of {numCoinFlips} coin flips were conducted.");
            Console.WriteLine($"The result was {numHeads} heads and {numTails} tails");

        }
    }
}
