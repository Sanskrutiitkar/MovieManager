using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MovieManager.ExceptionHandler;
using MovieManager.Model;
using Newtonsoft.Json;

namespace MovieManager.Services
{
    internal class SerializeDeserialize
    {
        private static string fileName = "MovieDataList.json";
        public static void SerializeData(List<Movies> movies)
        {
            File.WriteAllText(fileName,JsonConvert.SerializeObject(movies));    
        }
        public static List<Movies> DeserializeData() 
        {
            if (!File.Exists(fileName)) 
            {
                return new List<Movies>();
            }
            string json = File.ReadAllText(fileName);
            List<Movies> movies = JsonConvert.DeserializeObject<List<Movies>>(json);
            if(movies == null || movies.Count == 0)
            {
                return new List<Movies>();
            }
            return movies;
        }
    }

}
