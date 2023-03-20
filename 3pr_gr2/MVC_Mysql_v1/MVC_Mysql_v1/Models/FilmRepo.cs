using MySql.Data.MySqlClient;

namespace MVC_Mysql_v1.Models
{
    public class FilmRepo
    {
        private string connString;
        public FilmRepo(string connString)
        {
            this.connString = connString;
        }

        public List<Film> GetFilms()
        {
            List<Film> films = new List<Film>();
            using(MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM films";
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        films.Add(new Film
                        {
                            Id = rd.GetInt32(0),
                            Title = rd.GetString(1),
                            Time = rd.GetInt32(2),
                            Date = rd.GetDateTime(3),
                        });
                    }
                }
            }
            return films;
        }

        public void AddFilms(Film film)
        {
            
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string? formatForMySql = film.Date?.ToString("yyyy-MM-dd HH:mm:ss");
                cmd.CommandText = $"INSERT INTO films(title,time,date)"
                    +$"VALUES('{film.Title}','{film.Time}','{formatForMySql}')";
                cmd.ExecuteNonQuery();
                
            }
           
        }
    }
}
