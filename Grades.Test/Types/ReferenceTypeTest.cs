using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
    [TestClass]
    public class TypeTest
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.9f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            //grades = new float[5];
            grades[1] = 89.9f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            var book = "The best book";
            book = book.ToUpper();

            Assert.AreEqual(book, "THE BEST BOOK"); 
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2018,5,8);
            date.AddDays(1);
            Assert.AreEqual(date.Day, 8);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            Increment(x);

            Assert.AreEqual(x, 46);
        }

        private void Increment(int x)
        {
            x = x + 4;
        }


        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            var book1 = new GradeBook();
            var book2 = book1;

            GiveBookName(book2);

            Assert.AreEqual(book1.Name, "Aido knyga");
        }

        private void GiveBookName(GradeBook book)
        {
            book.Name = "Aido knyga";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Aidas";
            var name2 = "aidas";

            bool result = name1.Equals(name2,
                                StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void IntVariablesHoldsValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 200;

            Assert.AreNotEqual(x2, x1);
        }

        [TestMethod]
        public void GradeBookVariableHoldsReference()
        {
            var g1 = new GradeBook();
            var g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Test";

            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
