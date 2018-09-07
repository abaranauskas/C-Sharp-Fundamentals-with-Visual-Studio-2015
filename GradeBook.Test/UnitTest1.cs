using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace GradeBook.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //GradeBook testBook = new GradeBook("aido");
            var kint = "Labas";
            Assert.AreEqual(kint, "Labas");
        }
    }
}
