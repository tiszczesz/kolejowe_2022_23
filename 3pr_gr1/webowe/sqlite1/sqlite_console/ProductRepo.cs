using System.Data.SQLite;
namespace sqlite_console {
    public class ProductRepo{
    public void getProducts(){
        using (var connect = new SQLiteConnection("Data Source=appDb.db"))
        {
            connect.Open();
            var command = connect.CreateCommand();
            command.CommandText = @"SELECT * FROM Product";
            SQLiteDataReader rd = command.ExecuteReader();
            while(rd.Read()){
                Console.WriteLine($"{rd.GetString(1)} cena: {rd.GetDecimal(2)} opis: {rd.GetString(3)}");
            }
        }
    }
    public void addProduct(Product p){

    }

    public List<Product> GetProductsToList()
    {
        var products =  new List<Product>();
		using (var connect = new SQLiteConnection("Data Source=appDb.db"))
		{
			connect.Open();
			var command = connect.CreateCommand();
			command.CommandText = @"SELECT * FROM Product";
			SQLiteDataReader rd = command.ExecuteReader();
			while (rd.Read())
			{
                products.Add(new Product
                {
                    Id = rd.GetInt32(0),
                    Name = rd.GetString(1),
                    Price = rd.GetDecimal(2),
                    Description = rd.GetString(3)
                });
					
			}
		}
		return products;
    }
}
}
