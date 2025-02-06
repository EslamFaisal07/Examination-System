using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    internal class MCQ : Question
    {

        public override string Header { get => "MCQ Question"; }

       
        public MCQ(string body, Answers[] answers)
        {
            Body = body;
            List = answers;
        }
        public MCQ()
        {
        }



        public void CreateMCqQuestion()
        {
           
            Console.WriteLine(Header);

            Console.WriteLine("Enter Body of Question : ");

            Body = Console.ReadLine();


            double mark;

            do
            {
                Console.Write("Enter Mark Of Question :  ");
            }
            while ((!double.TryParse(Console.ReadLine() , out mark)) || (mark <0));

            Mark = mark;

        

            Console.WriteLine("Enter Choices of Question ");

            Answers[] answers = new Answers[4];

            for (int i = 0; i < answers.Length; i++)
            {

            string? input ;
                do
                {
                Console.Write($"Enter Choices Number {i + 1} ==> ");
                input = Console.ReadLine();



                    answers[i] = new Answers();
                    answers[i].AnswerId = i;
                    answers[i].AnswerText = input;
                    
                }
                while (string.IsNullOrEmpty(input));

            }


            List = answers;


            int rightAnswer;

            do
            {
                Console.Write("Enter The Right Answer : ");
            }
            while ((!int.TryParse(Console.ReadLine() , out rightAnswer)) || (rightAnswer<1 || rightAnswer>4));

            if (RightAnswer == null)
            {
                RightAnswer = new Answers();
            }




            RightAnswer.AnswerId = rightAnswer;
            RightAnswer.AnswerText = List[rightAnswer - 1].AnswerText;







            Console.Clear();


        }


    }
}
