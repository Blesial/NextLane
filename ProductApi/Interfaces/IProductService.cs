using ProductApi.Models;

namespace ProductApi.Interfaces
{
    public interface IProductService
    {
        Product CreateProduct(Product product);
        List<Product> GetProducts();
        Product GetProduct(int id);
        bool UpdateProduct(int id, Product updatedProduct);
        bool DeleteProduct(int id);
    }
}