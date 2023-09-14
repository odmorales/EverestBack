
using Product.Data.Context;
using Product.Domain;
using Product.Domain.Interfaces;

namespace Product.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Producto product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProducts(Producto product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public Producto? GetProductById(int productId)
        {
            return _context.Products.Where(x => x.Id == productId).FirstOrDefault();
        }

        public IEnumerable<Producto> GetProducts()
        {
            return _context.Products;
        }

        public void UpdateProducts(Producto product)
        {
            _context.Products.Attach(product);
            _context.SaveChanges();
        }
    }
}
