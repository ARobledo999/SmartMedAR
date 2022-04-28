using SmartMed.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SmartMed.Controllers.Tests
{
    [TestClass()]
    public class MedicationControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {



            var controller = new MedicationController();



            var result = controller.Get();
            result.GetHashCode();


            Assert.AreEqual(result.GetType().Name, "OkObjectResult");



        }

        [TestMethod()]
        public void PostTest()
        {
            var controller = new MedicationController();
            controller.Post(new Model.TbMedication { Name = "teste automático", quantity = 1 });

        }

        [TestMethod()]
        public void DeleteTest()
        {
            var controller = new MedicationController();
            controller.Delete(0);

        }

       
    }
}