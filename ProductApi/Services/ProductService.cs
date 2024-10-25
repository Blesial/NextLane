    using ProductApi.Interfaces;
    using ProductApi.Models;

    namespace ProductApi.Services
    {
        public class ProductService : IProductService
        {

            private readonly List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 9.99m },
                new Product { Id = 2, Name = "Product 2", Price = 19.99m },
                new Product { Id = 3, Name = "Product 3", Price = 29.99m }
            };
            
            private int nextId = 1;

            public Product CreateProduct(Product product)
            {
                product.Id = nextId++;
                products.Add(product);
                return product;
            }

            public List<Product> GetProducts() => products;

            public Product GetProduct(int id) => products.Find(p => p.Id == id);

            public bool UpdateProduct(int id, Product updatedProduct)
            {
                var product = GetProduct(id);
                if (product == null) return false;

                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                return true;
            }

            public bool DeleteProduct(int id)
            {
                var product = GetProduct(id);
                if (product == null) return false;

                products.Remove(product);
                return true;
            }
        }
    }
