using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook(string name = "No name provided")
        {
            _name = name;
            _gradesList = new List<float>();
        }

        public override void AddGrade(float grade)
        {
            _gradesList.Add(grade);

        }

        public override void WriteGrades(TextWriter destination)
        {
            //destination.WriteLine("foreach");
            foreach (var grade in _gradesList)
            {
                destination.WriteLine(grade);
            }                       
        }

        public override GradeStatistics ComputeStatistic()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;

            foreach (var grade in _gradesList)
            {
                stats.MaxGrade = Math.Max(grade, stats.MaxGrade);
                stats.MinGrade = Math.Min(grade, stats.MinGrade);
                sum += grade;
            }

            stats.AvgGrade = sum / _gradesList.Count;

            return stats;
        }

        public override IEnumerator GetEnumerator()
        {
           return _gradesList.GetEnumerator();
        }

        protected List<float> _gradesList;
             
    }
}
