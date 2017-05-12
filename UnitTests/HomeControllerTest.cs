

using System.Web.Mvc;
using LearningSystem.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Home_Return()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index",result.ViewName);
        }
    }
}
