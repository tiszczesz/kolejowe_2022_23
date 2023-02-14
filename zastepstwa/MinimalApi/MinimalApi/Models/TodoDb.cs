using Microsoft.EntityFrameworkCore;

namespace MinimalApi.Models
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options):base(options) {
            
        }

        public DbSet<Todo> Todos => Set<Todo>();

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Todo>().HasData(new Todo{Id=1,Name = "Wyjść z psem",IsComplete = false});
            modelBuilder.Entity<Todo>().HasData(new Todo{Id=2,Name = "Zjeść obiad",IsComplete = false});
            modelBuilder.Entity<Todo>().HasData(new Todo{Id=3,Name = "Ubrać się",IsComplete = false});
            modelBuilder.Entity<Todo>().HasData(new Todo{Id=4,Name = "Tralalala",IsComplete = false});
            modelBuilder.Entity<Todo>().HasData(new Todo{Id=5,Name = "Inne sprawy",IsComplete = false});
        }
    }
}
