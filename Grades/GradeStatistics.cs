namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            MinGrade = float.MaxValue;
            MaxGrade = float.MinValue;
        }



        public float MinGrade { get; set; }
        public float MaxGrade { get; set; }
        public float AvgGrade { get; set; }
        public char LetterGrade
        {
            get
            {
                char result;
                if (AvgGrade >= 90)
                {
                    result = 'a';
                }
                else if (AvgGrade >= 80)
                {
                    result = 'b';
                }
                else if (AvgGrade >= 70)
                {
                    result = 'c';
                }
                else if (AvgGrade >= 60)
                {
                    result = 'D';
                }
                else
                {
                    result = 'f';
                }
                return char.ToUpper(result);
            }
        }

        public string LetterGradeDescription
        {
            get
            {
                string result;

                switch (LetterGrade)
                {
                    case 'A':
                        result = "Excelent";
                        break;
                    case 'B':
                        result = "Above average";
                        break;
                    case 'C':
                        result = "Average";
                        break;
                    case 'D':
                        result = "Below Average";
                        break;
                    default:
                        result = "Fail";
                        break;
                }

                return result;
            }
        }
    }
}