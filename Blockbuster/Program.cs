namespace Blockbuster
{
    public class Program
    {
        public static void Main()
        {
            Blockbuster bb = new Blockbuster();
            
            Console.WriteLine("Welcome to GC Blockbuster!");
            Console.WriteLine("Please select a Movie from the list:");
            Movie m = bb.Checkout();

            bool anotherScene = true;
            while (anotherScene)
            {
                Console.WriteLine("What scene would you like to watch? Select 0-3");
                int sceneNum = int.Parse(Console.ReadLine());
                m.PrintScenes(sceneNum);

                Console.WriteLine("\nWatch another scene? Y/N");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    anotherScene = true;
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                    anotherScene = false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, please try again.");
                    continue;
                }
            }
        }
    }
}