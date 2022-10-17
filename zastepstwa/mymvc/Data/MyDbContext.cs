using Microsoft.EntityFrameworkCore;
using mymvc.Models;

namespace mymvc.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {      }

        public DbSet<Student>   Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Firstname = "Antoni", Lastname = "Małecki" },
                new Student { Id = 2, Firstname = "Antoni", Lastname = "Małecki" },
                new Student { Id = 3, Firstname = "Monika", Lastname = "Gruszka" },
                new Student { Id = 4, Firstname = "Renata", Lastname = "Malina" }
                );
        }

    }
}
