using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieManager.Services;
using MovieManager;


namespace MovieApplication.model
{
    public class MovieStore
    {
        MoviesManager moviesManager = new MoviesManager();
        public static void ShowMenu()
        {
            bool runningProgram = true;
            while (runningProgram)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Remove Movie");
                Console.WriteLine("3. Display Movies");
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. CLear All");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MoviesManager.AddMovie();
                        break;
                    case "2":
                        MoviesManager.RemoveMovie();
                        break;
                    case "3":
                        MoviesManager.DisplayMovie();
                        break;
                    case "4":
                        runningProgram = false;
                        Console.WriteLine("Exiting the application.");
                        break;
                    case "5":
                        MoviesManager.ClearAllMovies();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
 

