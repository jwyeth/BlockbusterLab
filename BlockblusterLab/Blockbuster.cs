using System;
using System.Collections.Generic;
using System.Text;

namespace BlockblusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            Movies = new List<Movie>();
            Movie m = new DVD("Shrek", Genre.Comedy, 120,
new List<string>() { "Swamp scene", "Deep Onion Scene", "Shrek save Anime" });
            Movie m1 = new DVD("Dawn of the Dead", Genre.Horror, 120,
                new List<string>() { "Shopping mall scene", "Bikers show up", "Zombies overrun the mall", "Shrek Saves the day" });
            Movie m2 = new DVD("Saving Private Ryan", Genre.Action, 120,
                new List<string>() { "D-Day", "Shrek takes a bullet to save Matt Damon", "Mortally wounded Shrek beats Hitler at Tic Tac Toe, winning the war" });
            Movies.Add(m);
            Movies.Add(m1);
            Movies.Add(m2);

            Movie m3 = new VHS("The Warriors", Genre.Action, 94, new List<string>() { "Can you dig it?", "Madness", "Come out to play", "end" });
            Movie m4 = new VHS("Lion King", Genre.Drama, 90, new List<string>() { "LK Beginning", "LK middle", "LK end" });
            Movie m5 = new VHS("Lion King 2", Genre.Comedy, 60, new List<string>() { "LK2 Beginning", "LK2 middle", "LK2 end" });

            Movies.Add(m3);
            Movies.Add(m4);
            Movies.Add(m5);
        }

        public void PrintMovies()
        {
            int i = 0;
            foreach (Movie m in Movies)
            {
                Console.WriteLine($"\t{i}: {m.Title}");
                i++;
            }

        }

        public Movie CheckOut()
        {
            while (true)
            {
                Console.WriteLine("Here's our available movie options: ");
                PrintMovies();
                Console.Write($"\nWhich movie would you like to checkout? ");

                int selectedMovieIndex = int.Parse(Console.ReadLine());

                Movies[selectedMovieIndex].PrintInfo();
                return Movies[selectedMovieIndex];
            }
        }
    }
}
