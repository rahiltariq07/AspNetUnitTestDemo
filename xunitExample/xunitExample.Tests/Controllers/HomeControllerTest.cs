using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xunitExample.Controllers;

namespace xunitExample.Tests.Controllers
{
    public class HomeControllerTest
    {
        //[Fact]
        //public void HomeController_Index_ValidResult()
        //{
        //    // AAA Methodolgy
        //    // Arrange
        //    HomeController controller = new HomeController();
        //    string expectedResult = "Hello, World!";

        //    // Act
        //    string result = controller.Index();

        //    // Assert
        //    Assert.Equal(expectedResult, result);
        //}

        [Fact]
        public void HomeController_Index_NegativeNumber()
        {
            // Arrange
            HomeController controller = new HomeController();
            int number = -5;
            string expectedResult = "Negative number";
            // Act
            string result = controller.Index(number);
            // Assert
            Assert.Equal(expectedResult, result);
            //Assert.IsType<string>(result);
        }

        [Fact]
        public void HomeController_Index_Zero()
        {
            // Arrange
            HomeController controller = new HomeController();
            int number = 0;
            string expectedResult = "Zero";
            // Act
            string result = controller.Index(number);
            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void HomeController_Index_PositiveNumber()
        {
            // Arrange
            HomeController controller = new HomeController();
            int number = 5;
            string expectedResult = "Positive number";
            // Act
            string result = controller.Index(number);
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
