using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetCoreWebApplication.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestsForMyASPNetCoreWebApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddtionMethod()
        {
            int a = 5;
            int b = 5;
            int expected = 10;

            ShaunzCoolController controller = new ShaunzCoolController();
            int result = controller.AddTwoIntegers(a, b);
            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
