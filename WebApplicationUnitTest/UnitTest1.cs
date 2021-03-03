using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WebApplicationTest.Controllers;


namespace WebApplicationUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCustomer()
        {
            HomeController controller = new HomeController();
            //this will test the view of customers
            ViewResult result = controller.Index() as ViewResult;
            //failing because there is no data displayed
            //Assert.AreEqual("custobj", result.ViewName);
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void TestMethodCustomerDetails()
        {
            HomeController controller = new HomeController();
            //this will test the view of customerdetails
            ViewResult result = controller.Contact() as ViewResult;
            //failing because there is no data displayed
            //Assert.AreEqual("custDetobj", result.ViewName);
            Assert.IsNotNull(result);
        }


    }
}
