using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatingShapeAreaCop;

namespace CalculatingShapeAreaTests
{
    [TestClass]
    public class UserChoiceManagementTests
    {
        [TestMethod]
        public void CorrectUserChoice()
        {
            Assert.AreEqual(1, new UserInput().CheckUserChoice("1"));
        }

        [TestMethod]
        public void WgongUserChoiceExclusion()
        {
            Assert.AreEqual("parallelogram", new UserInput().CheckUserInput("parallelogram"));
        }

        
    }
}
