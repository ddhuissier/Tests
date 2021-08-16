using ApiTest.Controllers;
using ApiTest.Core;
using ApiTest.Data;
using ApiTest.Models;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace TestsCompaign
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetProductById()
        {
            // Arrange
            var count = 1;
            var fakeProducts = A.CollectionOfDummy<Product>(count).AsEnumerable();
            var service = A.Fake<IProductService>();
            A.CallTo(() => service.GetProducts()).Returns(Task.FromResult(fakeProducts));
            ProductsController controller = new ProductsController(service);
            // Act
            var actionResult = await controller.Get(6);
            // Asset
            var result = actionResult.Result as OkObjectResult;
            var returnProducts = result.Value as IOrderedEnumerable<Product>;

            Assert.Equal(returnProducts.Count(), count);

        }
    }
}
