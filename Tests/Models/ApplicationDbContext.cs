using Microsoft.EntityFrameworkCore;
namespace Tests.Models
{
    internal class ApplicationDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D1BB1F;Initial Catalog=Mohirdev;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerCourse>()
                .HasKey(cc => new { cc.CustomerId, cc.CourseId });

            modelBuilder.Entity<CustomerCourse>()
               .HasOne(cc => cc.Customer)
               .WithMany(cu => cu.CustomerCourses)
               .HasForeignKey(cc => cc.CustomerId);

            modelBuilder.Entity<CustomerCourse>()
              .HasOne(cc => cc.Course)
              .WithMany(c => c.CustomerCourses)
              .HasForeignKey(cc => cc.CourseId);
        }
    }
}
//@"Data Source=DESKTOP-TJM6HU8;Initial Catalog=OdamlarDB;Integrated Security=True;TrustServerCertificate=True"
//@"Data Source=DESKTOP-D1BB1F;Initial Catalog=Mohirdev;Integrated Security=True;TrustServerCertificate=True"