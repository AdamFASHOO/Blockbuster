using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    public abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, Genre Category, int RunTime, params string[] Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes.ToList();
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("Runtime: " + RunTime + " minutes");
        }

        public void PrintScenes(int sceneNum)
        {
            if(sceneNum >= 0 && sceneNum <= 3)
            {
                Console.WriteLine(Scenes[sceneNum]);
            }
            else
            {
                Console.WriteLine("That was not an available scene, but here's what we have:");
                for (int i = 0; i < Scenes.Count; i++)
                {
                    Console.WriteLine($"Scene {i}: {Scenes[i]}");
                }
            }
        }
        public abstract void Play();
    }
}

