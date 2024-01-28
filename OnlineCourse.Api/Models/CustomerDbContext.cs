using Microsoft.EntityFrameworkCore;
namespace OnlineCourse.Api.Models
{
    internal class CustomerDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public CustomerDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=uu.db");
        }
    }
}
