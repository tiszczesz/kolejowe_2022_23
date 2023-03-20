

using System.Configuration;
using MySql.Data.MySqlClient;

namespace MySql_v1_products.Models; 

public class ProductRepo {

    private string connString;

    public ProductRepo(string connString) {
        this.connString = connString;
    }
    public List<Product> GetProducts() {
        List<Product> products = new List<Product>();
        using (MySqlConnection conn = new MySqlConnection(connString)) {
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM products";
            conn.Open();
            MySqlDataReader rd = command.ExecuteReader();
            if (rd.HasRows) {
                while (rd.Read()) {
                    products.Add(new Product {
                        Id = rd.GetInt32(0),
                        Name = rd.GetString(1),
                        Price = rd.GetDecimal(2),
                        Description = rd.GetString(3)
                    });
                }
            }
        }

        return products;
    }
}