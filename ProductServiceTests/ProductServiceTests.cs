using Moq;
using ProductApi.Interfaces;
using ProductApi.Models;
using Xunit;

namespace ProductServiceTests
{
    public class ProductServiceTests
    {
        private readonly Mock<IProductService> _mockProductService;

        public ProductServiceTests()
        {
            _mockProductService = new Mock<IProductService>();
        }

        [Fact]
        public void CreateProduct_ShouldAddProduct()
        {
            // Arrange
            var product = new Product { Name = "Test Product", Price = 10.99m };
            _mockProductService.Setup(s => s.CreateProduct(product))
                               .Returns(new Product { Id = 1, Name = "Test Product", Price = 10.99m });

            // Act
            var createdProduct = _mockProductService.Object.CreateProduct(product);


            // Assert
            Assert.Equal(1, createdProduct.Id);
            Assert.Equal("Test Product", createdProduct.Name);
        }

        [Fact]
        public void GetProducts_ShouldReturnListOfProducts()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 9.99m },
                new Product { Id = 2, Name = "Product 2", Price = 19.99m }
            };

            _mockProductService.Setup(s => s.GetProducts()).Returns(products);

            // Act
            var result = _mockProductService.Object.GetProducts();

            // Assert
            Assert.Equal(2, result.Count);
        }


        [Fact]
        public void GetProduct_ShouldReturnProductById()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Product 1", Price = 9.99m };
            _mockProductService.Setup(s => s.GetProduct(1)).Returns(product);

            // Act
            var retrievedProduct = _mockProductService.Object.GetProduct(1);

            // Assert
            Assert.NotNull(retrievedProduct);
            Assert.Equal(product.Name, retrievedProduct.Name);
        }

        [Fact]
        public void UpdateProduct_ShouldModifyExistingProduct()
        {
            // Arrange
            _mockProductService.Setup(s => s.UpdateProduct(1, It.IsAny<Product>()))
                .Returns(true);

            // Act
            var result = _mockProductService.Object.UpdateProduct(1, new Product { Name = "Updated Product", Price = 15.99m });

            // Assert
            Assert.True(result);
        }


        [Fact]
        public void DeleteProduct_ShouldRemoveProduct()
        {
            // Arrange
            var productIdToDelete = 1;
            var product = new Product { Id = productIdToDelete, Name = "Product 1", Price = 9.99m };

            _mockProductService.Setup(s => s.GetProduct(productIdToDelete)).Returns(product);
            _mockProductService.Setup(s => s.DeleteProduct(productIdToDelete)).Returns(true);

            // Act
            var result = _mockProductService.Object.DeleteProduct(productIdToDelete);

            // Assert
            Assert.True(result);
        }
    }

}