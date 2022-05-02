using Microsoft.EntityFrameworkCore;

namespace LOGINREPOSITORY.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbConnection.Connectionstr);
        }
    }
}
