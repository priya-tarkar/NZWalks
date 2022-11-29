using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tryweblist.Data;
using tryweblist.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tryweblist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
        
    {
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async  Task<IActionResult> Get()
        {
            return Ok(await _context.Categories.ToListAsync());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<Category> Get(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }
       /* [HttpGet("{[action]/id}")]
        public async Task<Category> test(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }*/

        // POST api/<CategoryController>
        /*  [HttpPost]
          public async void  Post([FromBody] Category cat)
          {


              await _context.Categories.AddAsync(cat);
             await _context.SaveChangesAsync();
          }*/
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Category category)
        {
            String connectionString = "DefaultEndpointsProtocol=https;AccountName=shoppingcartaccount;AccountKey=gW8zCvpYuF3Ywwm3FLz/zOaWNjCHoysz2XANMMzRIDLD+pnOkLhVlau7ojhwXSfGAjdi+sG6+D1H+AStrUS4rQ==;EndpointSuffix=core.windows.net";
            String containername = "shoppingcart";
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containername);
            BlobClient blobClient = containerClient.GetBlobClient(category.CategoryImage.FileName);
            MemoryStream ms = new MemoryStream();
            await category.CategoryImage.CopyToAsync(ms);
            ms.Position = 0;
            await blobClient.UploadAsync(ms);
            category.CategoryImagePath = blobClient.Uri.AbsoluteUri;

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return Ok("FUND");




        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Category cat)
        {
            
            var f= await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (f == null)
            {
                return NotFound();
            }
            else
            {
                /*f.Title = cat.Title;
                f.DisplayOrder = cat.DisplayOrder;*/
                _context.Categories.Update(f);
                _context.SaveChanges();
                return Ok(f);
            }
            

        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var f = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (f == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Categories.Remove(f);
                _context.SaveChanges();
                return Ok(f);
            }
        }



        }
    }

