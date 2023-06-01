using Microsoft.EntityFrameworkCore; 
using System.Reflection.Emit;

namespace BlogSystemApp.Models
{
    public class BlogDbContext : DbContext 
    { 

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        

        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()

                .HasMany(b => b.Comments)
                .WithOne(c => c.Blog)
                .HasForeignKey(c => c.BlogId)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            {
                
            }
            
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("your-connection-string");
        }
    }
}
