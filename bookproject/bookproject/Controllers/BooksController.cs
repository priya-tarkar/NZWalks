using bookproject.Data;
using bookproject.Filter;
using bookproject.Helper;
using bookproject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bookproject.Controllers
{
    [ApiKeyAuth]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromForm] Book books)
        {
            books.ImageUrl = await FileHelper.UploadImage(books.ImageFile);
            books.BookUrl = await FileHelper.UploadImage(books.BookFile);
            await _context.Books.AddAsync(books);
            await _context.SaveChangesAsync();
            return Ok("FUND");
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks(int? pageNumber, int? pageSize)
        {
            int currentPageNumber = pageNumber ?? 1;
            int currentPageSize = pageSize ?? 5;
            var books = await (from book in _context.Books
                                select new
                                {
                                    Id = book.Id,
                                    Name = book.Title,
                                    Imageurl = book.ImageUrl,
                                    Bookurl=book.BookUrl,
                                    description=book.Description
                                }).ToListAsync();

            return Ok(books.Skip((currentPageNumber-1)*currentPageSize).Take(currentPageSize));

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Booksdetails(int id)
        {
            var book = await (_context.Books.Where(x => x.Id == id).FirstOrDefaultAsync());
            return Ok(book);

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> TrendingBooks()
        {
            var books = await (from book in _context.Books
                               where book.Treding==true
                               select new
                               {
                                   Id = book.Id,
                                   Name = book.Title,
                                   Imageurl = book.ImageUrl,
                                   Bookurl = book.BookUrl,
                                   description = book.Description
                               }).ToListAsync();

            return Ok(books);

        }


        [HttpGet("[action]")]
        public async Task<IActionResult> NewBooks()
        {
            var books = await (from book in _context.Books
                                orderby book.CreatedDate descending 
                               select new
                               {
                                   Id = book.Id,
                                   Name = book.Title,
                                   Imageurl = book.ImageUrl,
                                   Bookurl = book.BookUrl,
                                   description = book.Description
                               }).Take(5).ToListAsync();

            return Ok(books);

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> SearchBooks(String query)
        {
            var books = await (from book in _context.Books
                               orderby book.Title.StartsWith(query)
                               select new
                               {
                                   Id = book.Id,
                                   Name = book.Title,
                                   Imageurl = book.ImageUrl,
                                   Bookurl = book.BookUrl,
                                   description = book.Description
                               }).Take(5).ToListAsync();

            return Ok(books);

        }











    }
}
