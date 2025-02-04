using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    internal class FinalExam : Exam
    {


        public FinalExam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
          
        }


        public override void CreateExam()
        {
            Questions = new List<Question>();

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int num;
                do
                {
                    Console.WriteLine($"please choose the type of question number {i + 1} (1 for true or false || 2 for MCQ )");

                }
                while ((!int.TryParse(Console.ReadLine(), out num)) || (num < 0 && num > 2));



                if (num == 1)
                {
                    TrueOrFalse TF = new TrueOrFalse();
                    TF.CreateTorFQuestion();
                    Questions.Add(TF);
                    

                }
                else
                {
                    MCQ mcq = new MCQ();
                    mcq.CreateMCqQuestion();
                    Questions.Add(mcq); ;
                }

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
                Console.WriteLine($"(Q{k + 1}). {Questions[k].Body} => {Questions[k]?.UserAnswer?.AnswerText}");

                Console.WriteLine("----------------------------------------------------------");
            }

            Console.WriteLine($"Your Exam Grade is {totalMarks} from  {counter}");

        }


        override public string ToString()
        {
            return $"Time: {Time}\nNumber of Questions: {NumberOfQuestions}";
        }



    }
}
