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
    public class CoversController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public CoversController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]

        public async Task<IActionResult> Post([FromForm] BookCover cover)
        {
            cover.ImageUrl = await FileHelper.UploadImage(cover.ImageFile);
            await _context.BookCovers.AddAsync(cover);
            await _context.SaveChangesAsync();
            return Ok("FUND");
        }


        [HttpGet]
        public async Task<IActionResult> GetCovers()
        {
            var covers = await (from cover in _context.BookWritter
                                 select new
                                 {
                                     Id = cover.Id,
                                     Name = cover.Name,
                                     Imageurl = cover.ImageUrl
                                 }).ToListAsync();

            return Ok(covers);

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Coversdetails(int id)
        {
            var covers = await (_context.BookCovers.Include(x => x.Books).Where(x => x.id == id).FirstOrDefaultAsync());
            return Ok(covers);

        }


    }
}
