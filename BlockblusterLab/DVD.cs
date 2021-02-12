using System;
using System.Collections.Generic;
using System.Text;

namespace BlockblusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }
        public override void Play()
        {
            while (true)
            {
                Console.WriteLine($"\nScenes of the movie:");
                PrintScenes();
                Console.Write($"\nWhich scene would you like to watch? (0 - {Scenes.Count - 1})");
                int sceneIndex = int.Parse(Console.ReadLine());

                Console.WriteLine($"\t{Scenes[sceneIndex]}");
                Console.Write("Watch another scene? (y/n) ");
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
    }
}
