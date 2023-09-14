
using Product.Domain.Common;

namespace Product.Domain.Interfaces
{
    public interface IProductRepository
    {
        void AddProduct(Producto product);
        IEnumerable<Producto> GetProducts();
        void DeleteProducts(Producto product);
        void UpdateProducts(Producto product);
        Producto? GetProductById(int productId);
    }
}
