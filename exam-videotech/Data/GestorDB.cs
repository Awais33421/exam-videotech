using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_videotech.model;
using MySqlConnector;

namespace exam_videotech.Data
{
    public class GestorDB
    {
        private MySqlConnection con;

        public GestorDB()
        {
            MySqlConnectionStringBuilder builder
                = new MySqlConnectionStringBuilder();

            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password= "";
            builder.Database= "videotech";

            con = new MySqlConnection(builder.ToString());
        }

        public void InsertMovie(Movie movie)
        {
            con.Open();
            string sql =
                 "INSERT INTO pelicula " +
                 "(titulo,director,anyo,disponible)" +
                 "VALUES " +
                 "(@titulo,@diterctor,@anyo,@disponible)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@titulo", movie.GetTitulo());
            cmd.Parameters.AddWithValue("@diterctor", movie.GetDirector());
            cmd.Parameters.AddWithValue("@anyo", movie.GetAnyo());
            cmd.Parameters.AddWithValue("@disponible", movie.IsDisponible());
            cmd.ExecuteNonQuery(); 
            con.Close();

        }

        public List<Movie> GetMovies() { 
        
            List<Movie> list = new List<Movie>();
            con.Open();
            string sql = "SELECT* FROM pelicula";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string title = reader.GetString("titulo");
                string director = reader.GetString("director ");
                int any = reader.GetInt32("anyo");
                bool disponible = reader.GetBoolean("disponible");

                Movie m = new Movie(
                    title,
                    director, 
                    any, 
                    disponible
                    );
            
            }
            
            
           reader.Close();
           con.Close();    
           return list;

        }
    }
}
