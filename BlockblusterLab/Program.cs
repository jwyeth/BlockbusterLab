using System;

namespace BlockblusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the GC Blockbluster!\n");
            Blockbuster b = new Blockbuster();
            while (true)
            {
                Movie selectedMovie = b.CheckOut();

                Console.Write($"\nWould you like to watch {selectedMovie.Title}? (y/n) ");
                string playMovie = Console.ReadLine();

                VHS selectedVHS;

                if (playMovie != "y")
                {
                    continue;
                }
                else
                {
                    selectedMovie.Play();
                }

                if (selectedMovie is VHS)
                {
                    selectedVHS = (VHS)selectedMovie;
                    Console.Write($"Would you like to rewind the movie? (y/n) ");
                    string rewindPrompt = Console.ReadLine();
                    if (rewindPrompt != "y")
                    {
                        Console.WriteLine("That's not very kind!");
                    }
                    else
                    {
                        Console.WriteLine("Thanks for being kind!");
                        selectedVHS.Rewind();
                    }

                }
                Console.Write($"Would you like to watch another movie? (y/n) ");
                string keepWatching = Console.ReadLine();
                if (keepWatching != "y")
                {
                    Console.WriteLine($"Thanks for visiting the Grand Circus Blockbuster, take care!");
                    break;
                }
            }
        }
    }
}
