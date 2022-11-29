using bookproject.Data;
using bookproject.Model;

namespace bookproject.Infrastructor
{
    public class ProductRepo : IProduct
    {
        private readonly ApplicationDbContext _context;

        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Products? product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();

        }

        public IEnumerable<Products> GetAll()
        {
            return _context.Products;
            _context.SaveChanges();

        }

        public Products GetProductsById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void update(Products product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
