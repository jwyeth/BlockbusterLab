using System;
using System.Collections.Generic;
using System.Text;

namespace BlockblusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }

        public override void Play()
        {
            while (true)
            {
                if (CurrentTime != 0)
                {
                    Console.WriteLine($"Playing from current scene: {Scenes[CurrentTime]}");
                    CurrentTime++;

                }
                else
                {
                    Console.WriteLine($"Starting movie from the beginning: {Scenes[CurrentTime]}");
                    CurrentTime++;
                }
                Console.Write($"Would you like to continue watching? (y/n) ");
                string keepWatching = Console.ReadLine();

                if (keepWatching != "y")
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
