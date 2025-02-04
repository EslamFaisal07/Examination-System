using System.Diagnostics;

namespace OOPEXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub01 = new Subject(1, "Math");
            sub01.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want to start the Exam (y | n)");

            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && char.Parse(input.ToLower()) == 'y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                sub01.Exam.ShowExam();

                Console.WriteLine($"Elapsed Time is : {stopwatch.Elapsed}");
            }
        }
    }
}
