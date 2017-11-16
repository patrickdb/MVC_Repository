using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCRepo.Controllers;

namespace UnitTests
{
    [TestClass]
    public class UnitTestExercise
    {
        [TestMethod]
        public void WhenControllerCalledThenContextFired()
        {
            PersoonController controller = new PersoonController();
            controller.Index();
        }
     }
}
