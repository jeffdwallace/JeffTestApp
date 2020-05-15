using JeffTestApp.Controllers;
using JeffTestApp.Models;
using JeffTestApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Security.Claims; 
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        

        [Fact]
        public void GetGridRepoTest()
        {
            // Arrange
            var mockRepo = new Mock<IGetGridRepository>();

            mockRepo.Setup(grid => grid.GetGridData()).Returns(new List<GridViewItem>());

        }

        [Fact]
        public void Homecontrollertest()
        {
            // Arrange
            var mockRepo = new Mock<IGetGridRepository>();

            var controller = new HomeController(mockRepo.Object);
            var userName = "dack873@gmail.com"; 

            var controllerContext = new Mock<ControllerContext>();
            var principal = new Moq.Mock<System.Security.Principal.IPrincipal>();
            principal.Setup(p => p.IsInRole("Administrator")).Returns(true);
            principal.SetupGet(x => x.Identity.Name).Returns(userName);
            controllerContext.SetupGet(x => x.HttpContext.User).Returns((ClaimsPrincipal)principal.Object);
            controller.ControllerContext = controllerContext.Object;

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<GridViewModel>(
                viewResult.ViewData.Model);
            //Assert.NotEmpty(model.Items);

            Assert.NotEmpty(model.Items);
        }
    }
}
