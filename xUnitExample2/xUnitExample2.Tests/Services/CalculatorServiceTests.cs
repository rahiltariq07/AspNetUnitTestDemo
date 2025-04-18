using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitExample2.Services;

namespace xUnitExample2.Tests.Services
{
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _calc = new();

        [Fact]
        public void Add_WhenCalled_ReturnsSum()
        {
            // Arrange
            var x = 3; var y = 5;

            // Act
            var result = _calc.Add(x, y);

            // Assert
            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        [InlineData(100, 10, 10)]
        public void Divide_ValidInputs_ReturnsQuotient(int x, int y, int expected)
        {
            var result = _calc.Divide(x, y);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calc.Divide(5, 0));
        }
    }
}
