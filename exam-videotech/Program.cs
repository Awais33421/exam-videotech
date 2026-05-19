using System.Reflection;
using exam_videotech.model;

namespace exam_videotech
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Jurassic Pakr", "Lambudar", 2005, false));
            movies.Add(new Movie("Inception", "James", 2014, true));
            movies.Add(new Movie("Harry Potter", "JK Rolling", 2002, true));

            Console.WriteLine("All Movies");
            foreach (Movie movie in movies) { 
            
                Console.WriteLine(movie.ToString());
            }


        }

    }
}
