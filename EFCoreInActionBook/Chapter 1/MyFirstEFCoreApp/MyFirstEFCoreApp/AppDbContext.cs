using Microsoft.EntityFrameworkCore;
using MyFirstEFCoreApp.Models;

namespace MyFirstEFCoreApp
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;
             Database=MyFirstEfCoreDb;
             Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; } //In Code first, tables are created based on the added DbSet properties
    }
}
