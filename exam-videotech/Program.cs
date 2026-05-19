using System.Reflection;
using exam_videotech.model;

namespace exam_videotech
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apartado 2.1 - Trabajar con la lista  
            List<Movie> movies = new List<Movie>();
            string directorName = "Nolan";

            movies.Add(new Movie("Jurassic Pakr", "Lambudar", 2005, false));
            movies.Add(new Movie("Inception", "James", 2014, true));
            movies.Add(new Movie("Harry Potter", "JK Rolling", 2002, true));

            Console.WriteLine("All Movies");
            foreach (Movie movie in movies) { 
            
                Console.WriteLine(movie.ToString());
            }

            Console.WriteLine($"{directorName} Movies: ");

            foreach (Movie movie in movies)
            {

                if (movie.GetDirector().Contains(directorName))
                {
                    Console.WriteLine(movie.ToString());
                }
            }

            //Apartado 2.2 - Fecha de registro  
            Console.WriteLine(" Current Date ");
            Console.WriteLine(DateTime.Now.ToShortDateString());

      

            //Apartado 2.3 - Guardar en fichero  
            SaveToFile(movies, "movies.text");

        }
        static void SaveToFile(List<Movie> movies, string path)
        {
            StreamWriter write = new StreamWriter(path);

            //Interstellar;Christopher Nolan;2014;True 

            foreach (Movie movie in movies)
            {
                write.WriteLine(
                    movie.GetTitulo + ";" +
                    movie.GetDirector + ";" +
                    movie.GetAnyo + ";" +
                    movie.IsDisponible
                    );
            }
            write.Close();
        }

    }
}
