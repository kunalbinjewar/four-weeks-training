using BookstoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    public class BookstoreContext: DbContext
    {
        public BookstoreContext() { }

        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-2N89NH9;Initial Catalog=BookstoreDb;Integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().ToTable("Books");
        }


    }
}