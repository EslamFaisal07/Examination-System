using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    internal abstract class Exam
    {
        public Exam()
        {
            Questions = new List<Question>();
        }
        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>();


        }

        public int Time { get; set; }

        public int NumberOfQuestions { get; set; }

        public  List<Question> Questions { get; set; }




        public abstract void CreateExam();


        public abstract void ShowGradeOfExam(); 

        public  void ShowExam()
        {
            Console.Clear();
            for (int i = 0; i < Questions?.Count; i++)
            {
                Question question = Questions[i];
                Console.WriteLine(question);

                for (int j = 0; j < question?.List?.Length; j++)
                {
                    Console.WriteLine($"{j+1}- {question.List[j]}");

                }
                int userAnswer;
                bool isParsed;
                do
                {
                    Console.Write("Please Enter Your Answer : ");
                    isParsed = int.TryParse(Console.ReadLine(), out userAnswer);
                } while ((!isParsed) || (userAnswer > 0 && userAnswer > 4));

                if (question.UserAnswer == null)
                {
                    question.UserAnswer = new Answers();
                }

                question.UserAnswer.AnswerId = userAnswer;
                question.UserAnswer.AnswerText = question?.List?[userAnswer - 1].AnswerText;
                Console.Clear() ;
            }
            Console.Clear();
            
            ShowGradeOfExam();

        }
    }
}
