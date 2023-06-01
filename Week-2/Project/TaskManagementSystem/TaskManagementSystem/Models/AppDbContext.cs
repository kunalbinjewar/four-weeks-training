using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystem.Models
{
    
namespace YourProjectNamespace.Data
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            public DbSet<Task> Tasks { get; set; }
        }
    }

}
