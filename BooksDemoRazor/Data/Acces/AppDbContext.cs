using BooksDemoRazor.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BooksDemoRazor.Data.Acces
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}


//DbContext'ten kalıtım al
// Constructor'da DbContextOptions içinde kendi context'ini tanımla
//DbSet ver

