using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class BookAuthorDbContext : DbContext
    {
        public BookAuthorDbContext(DbContextOptions<BookAuthorDbContext> options)
            : base(options)
        {

        }

        public DbSet<BookAuthor> BookAuthors { get; set; }
    }
}
