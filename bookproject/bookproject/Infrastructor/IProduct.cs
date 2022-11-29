using bookproject.Model;

namespace bookproject.Infrastructor
{
    public interface IProduct
    {
        IEnumerable<Products> GetAll();
        Products GetProductsById(int id);
        void Insert(Products product);
        void update(Products product);
        void Delete(Products product);
    }
}
