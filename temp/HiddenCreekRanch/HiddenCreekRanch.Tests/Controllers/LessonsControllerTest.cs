using System;
using System.Web.Mvc;
using HiddenCreekRanch.Controllers;
using NUnit.Framework;

namespace HiddenCreekRanch.Tests.Controllers
{
    [TestFixture]
    public class LessonsControllerTest
    {
        [Test]
        public void Index_Index_ViewName_Assert_AreEqual()
        {
            var controller = new LessonsController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
