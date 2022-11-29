using bookproject.Data;
using bookproject.Helper;
using bookproject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bookproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public WritersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] BookWritter writer)
        {
            writer.ImageUrl = await FileHelper.UploadImage(writer.ImageFile);
            await _context.BookWritter.AddAsync(writer);
            await _context.SaveChangesAsync();
            return Ok("FUND");
        }
        [HttpGet]
        public async Task<IActionResult> GetWritters()
        {
            var writers = await (from writer in _context.BookWritter
                                 select new
                                 {
                                     Id = writer.Id,
                                     Name = writer.Name,
                                     Imageurl = writer.ImageUrl
                                 }).ToListAsync();

            return Ok(writers);

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> writerdetails(int id)
        {
            var writer = await (_context.BookWritter.Include(x => x.Books).Where(x => x.Id == id).FirstOrDefaultAsync());
            return Ok(writer);

        }
    }
}
