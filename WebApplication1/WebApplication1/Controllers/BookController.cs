using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }
       /* [HttpPost]
        public async Task<IActionResult> Post([FromForm] Book books)
        {
            // books.ImageUrl = await FileHelper.UploadImage(books.ImageFile);
            // books.BookUrl = await FileHelper.UploadImage(books.BookFile);
            await _context.Books.AddAsync(books);
            await _context.SaveChangesAsync();
            return Ok("FUND");
        }*/
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {

            var books = await (from book in _context.Books
                               select new
                               {
                                   Id = book.Id,
                                   Name = book.Name,


                               }).ToListAsync();
            return Ok(books);

        }
    }
}
