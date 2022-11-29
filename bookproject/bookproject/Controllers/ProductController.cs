using bookproject.Data;
using bookproject.Infrastructor;
using bookproject.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bookproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProduct _Product;

        public ProductController( IProduct product)
        {
            _Product = product;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Products> GetProducts(String sortPrice)
        {
            IQueryable<Products> products;
            switch(sortPrice)
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok(_Product.GetProductsById(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post(Products product)
        {
            _Product.Insert(product);
            return CreatedAtAction("getproduct", new { id = product.Id }, product);

        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            var h = _Product.GetProductsById(id);
            _Product.update(h);

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var h = _Product.GetProductsById(id);
            _Product.Delete(h);
        }
    }
}
