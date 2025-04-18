using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitExample2.Entities;
using xUnitExample2.Repositories;
using xUnitExample2.Services;

namespace xUnitExample2.Tests.Services
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetPriceWithTax_ExistingProduct_ReturnsPricePlusTax()
        {
            // Arrange
            var fakeRepo = new Mock<IProductRepository>();
            fakeRepo
              .Setup(r => r.GetById(42))
              .Returns(new Product { Id = 42, Price = 100m });

            var svc = new ProductService(fakeRepo.Object);

            // Act
            var result = svc.GetPriceWithTax(42);

            // Assert
            Assert.Equal(120m, result);
        }

        [Fact]
        public void GetPriceWithTax_NonexistentProduct_Throws()
        {
            var fakeRepo = new Mock<IProductRepository>();
            fakeRepo
              .Setup(r => r.GetById(It.IsAny<int>()))
              .Returns((Product)null);

            var svc = new ProductService(fakeRepo.Object);

            Assert.Throws<ArgumentException>(
              () => svc.GetPriceWithTax(999)
            );
        }
    }
}
