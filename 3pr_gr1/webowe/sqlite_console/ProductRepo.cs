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
}
}
