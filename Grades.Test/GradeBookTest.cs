using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            var bookTest = new GradeBook();

            bookTest.AddGrade(10.1f);
            bookTest.AddGrade(99.9f);

            var stat = bookTest.ComputeStatistic();

            Assert.AreEqual(stat.MaxGrade, 99.9f);            
        }


        [TestMethod]
        public void ComputeMinimalGrade()
        {
            var bookTest = new GradeBook();

            bookTest.AddGrade(10.1f);
            bookTest.AddGrade(99.9f);

            var stat = bookTest.ComputeStatistic();

            Assert.AreEqual(stat.MinGrade, 10.1f);
        }


        [TestMethod]
        public void ComputeAverageGrade()
        {
            var bookTest = new GradeBook();

            bookTest.AddGrade(91);
            bookTest.AddGrade(89.5f);
            bookTest.AddGrade(75);

            var stat = bookTest.ComputeStatistic();

            Assert.AreEqual(stat.AvgGrade, 85.16f, 0.01); //0.01 delta ledziama paklaida
        }
    }
}
