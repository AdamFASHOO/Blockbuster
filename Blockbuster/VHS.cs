using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; } = 0;

        public VHS(string Title, Genre Category, int RunTime, params string[] Scenes) : base(Title, Category, RunTime, Scenes)
        {
        }
        public override void Play()
        {
            Console.WriteLine(Scenes[CurrentScene]);
            CurrentScene++;
        }
        public void Rewind()
        {
            CurrentScene = 0;
        }
    }
}
