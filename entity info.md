# Wykorzystanie EF bez migracji
## 1. Dodanie pakietów
EntityFramework.core
* dla MSSQL Microsoft.EntityFrameworkCore
* dle SQLite Microsoft.EntityFrameworkCore.Sqlite
* dla MySql Pomelo.EntityFrameworkCore.MySql

* Dla migracji Microsoft.EntityFrameworkCore.Tools

## 2. Dodanie Connection string w appconfig
* dla MSSQL 
```json
"ConnectionStrings": {
        "myConn": "Data Source=(localdb)\\MSSQLLocalDB;Database=MyMVC1;Integrated Security=True"
    }
```

* dla SQLite 
```json
"ConnectionStrings": {
        "myConn": "Data Source=LocalDatabase.db"
    }
```

* dla MySql
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=sp_cw1;User=root;Password=;"
  }
```
## 3. DBContext
* dla MySql
```cs
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :
           base(options)
        {  }

        public DbSet<Book> Books { get; set; } //dla modelu Book
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>(entity => {  //mapowanie do tabelki
                entity.ToTable("book");
            });
        }
    }

    public class Book  //model
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Editor { get; set; }
        public decimal? Price { get; set; }
    }
```
## 4. Użycie w Program.cs

* dla MySql w Program.cs
```cs
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
var app = builder.Build();

```
