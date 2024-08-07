using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Model
{
    public class Movies
    {
        public string MovieId {  get; set; }
        public string MovieName {  get; set; }
        public string MovieGenre { get; set; }
        public int MovieReleaseYear { get; set; }
        //public static int movieCount=0;

        public Movies()
        {
           
        }

        public Movies(string movieId, string movieName, string movieGenre, int movieReleaseYear)
        {
            MovieId = GetMovieId(movieName, movieGenre, movieReleaseYear);
            MovieName = movieName;
            MovieGenre = movieGenre;
            MovieReleaseYear = movieReleaseYear;
        }

        private string GetMovieId(string movieName, string movieGenre, int movieReleaseYear)
        {
            return movieName.Substring(0, 2) + movieGenre.Substring(0, 2) + movieReleaseYear.ToString().Substring(2, 2);
        }

     


    }
}
