using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumberGuessingGame
{
    class program
    {
        const int range = 100;
        static void Main(string[] args)
        {
            
            

            bool keepPlaying = true;

            do
            {
                Random r = new Random();
                int randomNumber = r.Next(range);

                bool win = false;

                //Console.Write("Guess a number in between 0 and {0}: ",range);
                //int input = int.Parse(Console.ReadLine());
                
                int input = readIntFromConsole(string.Format("Guess a number in between 0 and {0}: ", (range-1)));
                int amountGuess = 1;

                while (input != randomNumber)
                {
                    amountGuess++;
                    //Console.WriteLine(input < randomNumber ? "Too low!! Guess Higher..." : "Too high!!! Guess Lower...");
                    //
                    //input = int.Parse(Console.ReadLine());
                    input = readIntFromConsole((input < randomNumber ? "Too low!! Guess Higher..." : "Too high!!! Guess Lower...") +Environment.NewLine +"Guess a number in between 0 and " +(range-1)+": ");
                    //Console.Write("Guess a number in between 0 and 100: ");

                }

                Console.WriteLine(Environment.NewLine +"Thank you for playing the game! You took {0} attempts", amountGuess);

                Console.WriteLine(Environment.NewLine +"Do want to play again? (y/n): ");
                string playOption = Console.ReadLine();

                if (playOption.ToLower() == "n")
                    keepPlaying = false;

                Console.WriteLine();

            } while (keepPlaying);
            
            Console.WriteLine("Press any key to finish the game");
            Console.ReadKey(true);
        }

        public static int readIntFromConsole(string message)
        {
            Console.WriteLine(message);
            //Console.Write("Guess a number in between 0 and 100: ");
            return int.Parse(Console.ReadLine());
        }
    }
}