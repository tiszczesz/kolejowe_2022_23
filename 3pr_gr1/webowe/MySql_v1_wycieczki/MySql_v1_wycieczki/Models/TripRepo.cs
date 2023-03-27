using MySql.Data.MySqlClient;

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
                        DateOnly? date = DateOnly.FromDateTime(rd.GetDateTime(3));                            
                        tripList.Add(new Trip
                        {
                            Id = rd.GetInt32(0),
                            Place = rd.GetString(1),
                            Price = rd.GetDecimal(2),
                            Date = date
                        }) ;
                    }
                }
            }

            return tripList;
        }
    }
}
