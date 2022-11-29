/*using bookproject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookproject.Controllers
{
   // [ApiVersion("2.0")]
    //[Route("api/v{version:apiVersion}/Home")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

       
       
            static List<BookWritter> writers = new List<BookWritter>
        {
            new BookWritter(){Id=1,Name="priya",Gender="Female"},
            new BookWritter(){Id=2,Name="tarkar",Gender="Male"},
            new BookWritter(){Id=3,Name="Ramesh",Gender="Trans"}
        };
            [HttpGet]
            public IEnumerable<BookWritter> Get()
            {
                return writers;
            }

        }
    }*/

