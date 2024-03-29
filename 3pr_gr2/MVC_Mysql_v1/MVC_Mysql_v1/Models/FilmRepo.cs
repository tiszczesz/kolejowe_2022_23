﻿using MySql.Data.MySqlClient;

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
                        try
                        {
                      films.Add(new Film
                                            {
                                                Id = rd.GetInt32(0),
                                                Title = rd.GetString(1),
                                                Time = rd.GetInt32(2),
                                                Date = rd.GetDateTime(3),
                                            });
                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                      
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
                formatForMySql = formatForMySql ?? "2022-09-09";
                cmd.CommandText = $"INSERT INTO films(title,time,date)"
                    +$"VALUES('{film.Title}','{film.Time}','{formatForMySql}')";
                cmd.ExecuteNonQuery();
                
            }
           
        }
        public void DeleteFilms(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();                
                cmd.CommandText = $"DELETE FROM films WHERE id={id}";                  
                cmd.ExecuteNonQuery();
            }

        }

        public Film? GetById(int id)
        {
            Film? film=null;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM films WHERE id={id}";
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    film = new Film
                    {
                        Id = rd.GetInt32(0),
                        Title = rd.GetString(1),
                        Time = rd.GetInt32(2),
                        Date = rd.GetDateTime(3)
                    };
                }
            }
            return film;
        }
        public void UpdateFilm(int id,Film film)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string? formatForMySql = film.Date?.ToString("yyyy-MM-dd HH:mm:ss");
                cmd.CommandText = 
                $"UPDATE films SET title='{film.Title}',time={film.Time}," +
                   $"date='{formatForMySql}', time={film.Time} WHERE id={id}";
                cmd.ExecuteNonQuery();               
            }
        }
    }
}
