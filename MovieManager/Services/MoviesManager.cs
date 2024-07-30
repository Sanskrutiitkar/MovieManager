using System.Collections;
using MovieManager.ExceptionHandler;
using MovieManager.Model;

namespace MovieManager.Services
{
    public class MoviesManager : Movies
    {
        public MoviesManager()
        {
            movies = SerializeDeserialize.DeserializeData();
           // movieCount = movies.Count;
        }

        public static List<Movies> movies = new List<Movies>();
        // private static int movieCount = 0;
         
        public static int GetCount()
        {
            return movies.Count;
        }
        public static void AddMovie()
        {
            Console.WriteLine("Enter Movie Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enetr Movie Genere : ");
            string genere = Console.ReadLine();
            Console.WriteLine("Eneter Year of release : ");
            int year = int.Parse(Console.ReadLine());
            string movieId = "";
            Movies addNewMovie = new Movies(movieId, name, genere, year);

            try
            {

                if (GetCount() >= 5)
                {
                    throw new CapacityFullException("Capacity of Movie Store is full.");
                }

                movies.Add(addNewMovie);
                SerializeDeserialize.SerializeData(movies);
                Console.WriteLine("Movie Added Successfully.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void RemoveMovie()
        {
            Console.WriteLine("Eneter Movie Id to delete : ");
            string movieId = Console.ReadLine();
            foreach (Movies everyMovie in movies)
            {
                if (everyMovie.MovieId == movieId)
                {
                    movies.Remove(everyMovie);
                    SerializeDeserialize.SerializeData(movies);
                    Console.WriteLine("Movie Removed Successfully");
                    break;
                }
                Console.WriteLine("movie with this ID does not exist");
                
            }


        }
        public static void DisplayMovie()
        {
            try
            {
                // Check if the movies list is null or empty before iterating
                if (movies == null || GetCount() == 0)
                {
                    throw new EmptyMovieStoreException("The movie store is empty; no movies present to display.");
                }

                // Iterate through the movies list only if it is not empty
                foreach (Movies everyMovie in movies)
                {
                    Console.WriteLine("Movie ID : " + everyMovie.MovieId);
                    Console.WriteLine("Movie Name : " + everyMovie.MovieName);
                    Console.WriteLine("Movie Genre : " + everyMovie.MovieGenre);
                    Console.WriteLine("Year of Release : " + everyMovie.MovieReleaseYear);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}

