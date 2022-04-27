using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, params string[] Scenes) : base(Title, Category, RunTime, Scenes)
        {
        }

        public override void Play()
        {
            Console.WriteLine("What scene would you like to watch?\nPlease input 1 to "+(Scenes.Count - 1));
            string input = Console.ReadLine();
            int index = int.Parse(input);
            string scene = Scenes[index];
            Console.WriteLine(scene);
        }
    }
}
