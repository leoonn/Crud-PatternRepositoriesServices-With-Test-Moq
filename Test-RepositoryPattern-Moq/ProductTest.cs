using Crud_Pattern_Repository.Controllers;
using Crud_Pattern_Repository.Interfaces;
using Crud_Pattern_Repository.Models;
using Crud_Pattern_Repository.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Xunit;

namespace Test_RepositoryPattern_Moq
{
    public class ProductTest
    {
        [Fact]
        public void Post_InsertMethod_ShouldReturnedStatusCodeOk()
        {
            var repoMock = new Mock<IBaseRepository<Product>>();
            var serviceMock = new Mock<IBaseService<Product>>();
            var prodCtrl = new ProductController(serviceMock.Object);
            Product prodMock = new Product(1, "Iphone", "Iphone", 3000, 5000, 5); 

            var response = prodCtrl.Create(prodMock);

            Assert.IsType<RedirectToActionResult>(response.Result);
        }
    }
}
