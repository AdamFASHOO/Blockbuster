using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster()
        {
            Movies.Add(new DVD("Hot Rod", Genre.Comedy, 88, "Rod does a wheelie", "Frank beats up Rod", "Rod does stunts", "Rod beats up Frank"));
            Movies.Add(new DVD("Superbad", Genre.Comedy, 119, "Fogell gets a fake ID", "Fogell gets taken by the cops", "Fogell escapes the cops", "The gang goes to the party"));
            Movies.Add(new DVD("Scream", Genre.Horror, 114, "Phone call", "random screaming", "lots of stabbing", "villian revealed"));
            Movies.Add(new VHS("Star Wars", Genre.Action, 121, "Luke appears", "Obi-Wan does the thing", "Darth Vader responds", "Jedis win"));
            Movies.Add(new VHS("Spider Man", Genre.Action, 148, "Peter is a nerd", "Peter gets bitten", "Peter becomes Spider-Man", "Spider-Man wins"));
            Movies.Add(new VHS("The Exorcist", Genre.Horror, 132, "Eerie opening", "Posession", "scary and screaming", "Shrek saves the world"));
        }

        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"Index: {i}, {m.Title}");
            }
        }

        public Movie Checkout()
        {
            PrintMovies();
            Console.WriteLine("Please select a movie you want to checkout:");
            string input = Console.ReadLine();
            Console.WriteLine();

            int index = int.Parse(input);
            Movie m = Movies[index];
            m.PrintInfo();
            return m;
           
        }
    }
}
