using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    internal class PracticalExam : Exam
    {
 
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
            
        }

        public PracticalExam()
        {
        }

        public override void CreateExam()
        {
            Questions = new List<Question>();

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                MCQ mcq = new MCQ();
                mcq.CreateMCqQuestion();
                Questions.Add(mcq);
            }
        }

        public override void ShowGradeOfExam()
        {
            Console.WriteLine("Your Answers");
            double totalMarks = 0;
            double counter = 0;
            for (int k = 0; k < Questions?.Count; k++)
            {
                counter += Questions[k].Mark;
                if (Questions[k]?.RightAnswer?.AnswerId == Questions[k]?.UserAnswer?.AnswerId)
                {
                    totalMarks += Questions[k].Mark;
                }
                Console.WriteLine($"(Q{k + 1}). {Questions[k].Body} => {Questions[k].UserAnswer?.AnswerText}");

                Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"THe Right Answer Of Question {k+1} is ==> {Questions[k]?.RightAnswer?.AnswerText}");
                Console.WriteLine("----------------------------------------------------------");

            }

            Console.WriteLine($"Your Exam Grade is {totalMarks} from  {counter}");
        }

  
    }
}
