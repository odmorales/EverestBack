
using Product.Application.Models;
using Product.Domain;
using Product.Domain.Common;

namespace Product.Application.Interfaces
{
    public interface IProductService
    {
        string AddProduct(ProductDTO product);
        IEnumerable<Producto> GetProducts();
        string DeleteProducts(int productId);
        string UpdateProducts(ProductUpdate producto);
    }
}
