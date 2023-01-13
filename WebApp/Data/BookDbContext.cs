using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) 
            : base(options) 
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
