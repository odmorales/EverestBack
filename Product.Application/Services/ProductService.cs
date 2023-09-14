using AutoMapper;
using Product.Application.Interfaces;
using Product.Application.Models;
using Product.Domain;
using Product.Domain.Interfaces;
using System.IO;


namespace Product.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public string AddProduct(ProductDTO product)
        {
            try
            {
                var producto = _mapper.Map<Producto>(product);
                _productRepository.AddProduct(producto);
                return $"El producto {product.Nombre} ha sido registrado correctamente";
            }catch( Exception ex)
            {
                return $"Hubo un error al registrar el producto. {ex.Message} ";
            }
        }

        public string DeleteProducts(int productId)
        {
            try
            {
                var producto = _productRepository.GetProductById(productId);
                if(producto != null)
                {
                    _productRepository.DeleteProducts(producto);
                    return $"El producto {producto.Nombre} ha sido eliminado correctamente";
                }
                return $"El producto con el id: {productId} No se encuentra registrado";
            }
            catch (Exception ex)
            {
                return $"Hubo un error al eliminar el producto. {ex.Message} ";
            }
        }

        public IEnumerable<Producto> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public string UpdateProducts(ProductUpdate producto)
        {
            try
            {
                var productoUpdate = _productRepository.GetProductById(producto.Id);
                if (productoUpdate != null)
                {
                    _mapper.Map(producto, productoUpdate, typeof(ProductUpdate), typeof(Producto));
                    _productRepository.UpdateProducts(productoUpdate);
                    return $"El producto {producto.Nombre} ha sido actualizado correctamente";
                }
                return $"El producto con el id: {producto!.Id} No se encuentra registrado";
            }
            catch (Exception ex)
            {
                return $"Hubo un error al actualizar el producto. {ex.Message} ";
            }
        }
    }
}
