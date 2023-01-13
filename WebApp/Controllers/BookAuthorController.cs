using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAuthorController : ControllerBase
    {
        private readonly BookAuthorDbContext _context;
        public BookAuthorController(BookAuthorDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<BookAuthor>> Get()
            => await _context.BookAuthors.ToListAsync();


    }
}


