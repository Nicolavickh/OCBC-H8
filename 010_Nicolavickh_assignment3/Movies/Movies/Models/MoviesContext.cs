using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MoviesContext
    {
        public string ConnectionString { get; set; }

        public MoviesContext(string conn){
            this.ConnectionString = conn;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MoviesItem> GetAllMovies() {
            List<MoviesItem> list = new List<MoviesItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movies", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MoviesItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            release_date = reader.GetDateTime("release_date")
                        });
                    }
                }
            }
            return list;
        }

        public List<MoviesItem> GetMoviesById(string id)
        {
            List<MoviesItem> list = new List<MoviesItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movies WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MoviesItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetString("duration"),
                            release_date = reader.GetDateTime("release_date")
                        });
                    }
                }
            }

            return list;
        }

        public string AddMovie(MoviesItem movie)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO movies(name, genre, duration, release_date) VALUES (@name, @genre, @duration, @release_date)", conn);
                cmd.Parameters.AddWithValue("@name", movie.name);
                cmd.Parameters.AddWithValue("@genre", movie.genre);
                cmd.Parameters.AddWithValue("@duration", movie.duration);
                cmd.Parameters.AddWithValue("@release_date", movie.release_date);

                var recs = cmd.ExecuteNonQuery();

                if (recs == 1)
                {
                    return "Success!";
                }
                else
                {
                    return "Failed!";
                }
            }
        }

        public string UpdateMovie(int id, MoviesItem newMovie)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand updt = new MySqlCommand("UPDATE movies SET name=@name,genre=@genre,duration=@duration,release_date=@release_date WHERE id=@id", conn);
                updt.Parameters.AddWithValue("@name", newMovie.name);
                updt.Parameters.AddWithValue("@genre", newMovie.genre);
                updt.Parameters.AddWithValue("@duration", newMovie.duration);
                updt.Parameters.AddWithValue("@release_date", newMovie.release_date);
                updt.Parameters.AddWithValue("@id", id);
                var recs = updt.ExecuteNonQuery();

                if (recs == 1)
                {
                    return "Success!";
                }
                else
                {
                    return "Failed!";
                }
            }
        }

        public string DeletMovie(int id) {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand del = new MySqlCommand("DELETE FROM movies WHERE id=@id", conn);
                del.Parameters.AddWithValue("@id", id);
                var recs = del.ExecuteNonQuery();

                if (recs == 1)
                {
                    return "Success!";
                }
                else
                {
                    return "Failed!";
                }
            }
        }

    }
}
