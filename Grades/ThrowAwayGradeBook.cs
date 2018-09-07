using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook(string name)
            :base(name) { }

        public override GradeStatistics ComputeStatistic()
        {
            float minGrade = float.MaxValue;

            foreach (var grade in _gradesList)
            {
                minGrade = Math.Min(grade, minGrade);
            }

            _gradesList.Remove(minGrade);


            return base.ComputeStatistic();
        }
    }
}
