using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);
            //WriteResult("labas", 9.5f, 9.6f, 9.782f);






            //book.Name = "Anonimo knyga";
            //ignoruos property kodo algoritmas


            //Console.WriteLine(book.Name);            

            //book.NameChanged = new NameChangedDelagate(OnNameChange); //kai event jau negalima taip perduoti deleguojamo metodo
            //book.NameChanged += OnNameChange;
            //book.NameChanged += OnNameChange1;
            //book.NameChanged += OnNameChange1;  //kai event gali but tik += arba -=
            //book.NameChanged -= OnNameChange1; //nuims metoda

            //book.NameChanged = new NameChangedDelagate(OnNameChange); // si eilute nuresetintu kitu eventus jei delegate

            //book.Name = "aido knyga";
            //book.Name = "kito knyga";




            //SpeechSynthesizer syth = new SpeechSynthesizer();
            //syth.Speak("Hello! This is a Grade Book program!");           
        }

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook("Aido Knyga");
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistic();

            book.AddGrade(6.5f);

            foreach (var grade in book)
            {
                Console.WriteLine(grade);
            }

            WriteResult("Highest grade", (int)stats.MaxGrade);
            WriteResult("Average grade", stats.AvgGrade);
            WriteResult("Lowest grade", stats.MinGrade);
            WriteResult("Your letter Grade is ", stats.LetterGrade);
            WriteResult("And it is ", stats.LetterGradeDescription);
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
                //outputFile.Close(); //using pakeicia sita eilute
            }

            //book.WriteGrades(Console.Out);

            //outputFile.Close(); //using pakeicia sita eilute
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(96.6f);
            book.AddGrade(91f);
            book.AddGrade(72.5f);
            book.AddGrade(7.5f);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                do
                {
                    Console.WriteLine("Iveskite Knygos varda");
                    var vardas = Console.ReadLine();
                    if (!String.IsNullOrEmpty(vardas))
                    {
                        book.Name = vardas;
                        break;
                    }
                } while (true);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                //return;
            }
        }



        private static void OnNameChange1(object sender, NameChangedEvetsArgs args)
        {
            Console.WriteLine("******Kitas metodas*******");
        }

        private static void OnNameChange(object sender, NameChangedEvetsArgs args)
        {
            Console.WriteLine($"Vardas Pakeistas is {args.OldValue} i {args.NewValue}"); ;
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}"); //result:C = curency
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, char result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result.ToUpper()}");
        }



        static void WriteResult(string description, params float[] result) // "params" keyword iskvieciant metoda visi parametrai kurie butu irasyti po descriptio butu sukelti i float array
        {
            Console.WriteLine($"{description}: {result[2]:F2}"); //F2 skaiciu po kamblelio skaicius
        }
    }
}
