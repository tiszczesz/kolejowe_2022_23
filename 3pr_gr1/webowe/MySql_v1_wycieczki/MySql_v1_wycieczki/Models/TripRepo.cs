using MySql.Data.MySqlClient;
using System.Globalization;

namespace MySql_v1_wycieczki.Models
{
    public class TripRepo
    {
        private string connString;
        public TripRepo(string connString)
        {
            this.connString = connString;
        }
        public List<Trip> GetAll()
        {
            List<Trip> tripList = new List<Trip>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM trips";
                MySqlDataReader rd = command.ExecuteReader();
                if(rd.HasRows)
                {
                    while(rd.Read())
                    {
                                                
                        tripList.Add(new Trip
                        {
                            Id = rd.GetInt32(0),
                            Place = rd.GetString(1),
                            Price = rd.GetDecimal(2),
                            Date = rd.GetDateTime(3)
                        }) ;
                    }
                }
            }

            return tripList;
        }

        public void InsertTrip(Trip trip)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string? formatForMySql = trip.Date?.ToString("yyyy-MM-dd HH:mm:ss");
                string? priceInfo = trip.Price?.ToString(CultureInfo.InvariantCulture);
                command.CommandText = "INSERT INTO trips(place,price,date) "
                    +$"VALUES('{trip.Place}','{ priceInfo}','{formatForMySql}')";
                command.ExecuteNonQuery();
            }
        }
    }
}
