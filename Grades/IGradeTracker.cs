using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public interface IGradeTracker : IEnumerable
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistic();
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
        
    }
}