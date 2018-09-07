using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistic();
        public abstract void WriteGrades(TextWriter destination);

        public abstract IEnumerator GetEnumerator();

        public string Name
        {
            get { return _name; }
            set
            {

                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (_name != value)
                {
                    if (NameChanged != null)   //si kodo dalis apsaugos nuo erro jei vardas bu pakeistas pries tai kai metodas priskirtas delegate
                    {
                        NameChangedEvetsArgs args = new NameChangedEvetsArgs();
                        args.OldValue = _name;
                        args.NewValue = value;

                        NameChanged(this, args);
                    }
                    _name = value;
                }

            }
        }

        public event NameChangedDelagate NameChanged;

        protected string _name;
    }
}
