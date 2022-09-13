using CaseStudy3_FoodDonationManagement.Controllers;
using CaseStudy3_FoodDonationManagement.Core;
using CaseStudy3_FoodDonationManagement.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace CaseStudy3_FoodDonar.Tests
{
    [TestClass]
    public class FoodDonarControllerTests
    {
        [TestMethod]
        public void GetAll_ReturnsAllDonars()
        {
            var mockRepo = new Mock<IFoodDonar>();
            mockRepo.Setup(x => x.GetAllDonars())
                .Returns(GetTestDonar);


            var controller = new FoodDonarController(mockRepo.Object);
            IActionResult actionResult = controller.Get();
            Assert.IsNotNull(actionResult);
            Assert.IsInstanceOfType(actionResult, typeof(OkObjectResult));
        }

        [TestMethod]
        public void TestPostMethodReturn200Status()
        {
            var mockRepo = new Mock<IFoodDonar>();
            var controller = new FoodDonarController(mockRepo.Object);
            Microsoft.AspNetCore.Mvc.IActionResult actionResult = controller.Post(new SchoolModel { StudentDonarName = "Shayam", StudentDonarCity = "Delhi", StudentDonarAddress = "Dwarka" });
            Assert.IsNotNull(actionResult);
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }




        private IEnumerable<SchoolModel> GetTestDonar()
        {
            var donar = new List<SchoolModel>();
            donar.Add(new SchoolModel
            {
                StudentDonarId = 1,
                StudentDonarName= "Manjeet",
                StudentDonarCity = "delhi",
                StudentDonarAddress = "najafgarh"
            });
            return donar;
        }
    }
}
