using E_CommerceApp;
using Microsoft.EntityFrameworkCore;
public class EcommerceDbContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //if (!optionsBuilder.IsConfigured)
        //{
        //}
        optionsBuilder.UseSqlServer("Server = localhost; Database = master; Trusted_Connection = True;");
    }
}

