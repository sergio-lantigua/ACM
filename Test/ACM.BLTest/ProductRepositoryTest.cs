using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //-- Arrange
            ProductRepository productRepository = new ProductRepository();

            Product expected = new Product(1)
            {
                ProductName = "Creatina",
                Description = "Enhance the strength of the muscle",
                CurrentPrice = 20.25M
            };



            //-- Act
            Product actual = productRepository.Retrieve(1);


            //-- Assert
            Assert.Equal(expected.ProductId, actual.ProductId);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.Description, actual.Description);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
        }

        [Fact]
        public void SaveTestValid()
        {
            //-- Arrange
            ProductRepository productRepository = new ProductRepository();

            Product updatedProduct = new Product(1)
            {
                ProductName = "Creatina",
                Description = "Enhance the strength of the muscle",
                CurrentPrice = 20.25M,
                HasChanges = true
            };



            //-- Act
            bool actual = productRepository.Save(updatedProduct);


            //-- Assert
            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            //-- Arrange
            ProductRepository productRepository = new ProductRepository();

            Product updatedProduct = new Product(1)
            {
                ProductName = "Creatina",
                Description = "Enhance the strength of the muscle",
                CurrentPrice = null,
                HasChanges = true
            };



            //-- Act
            bool actual = productRepository.Save(updatedProduct);


            //-- Assert
            Assert.False(actual);
        }

    }
}
