using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class AuthorDbContext : DbContext
    {
        public AuthorDbContext(DbContextOptions<AuthorDbContext> options)
            : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
    }
}

