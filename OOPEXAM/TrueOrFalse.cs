using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    internal class TrueOrFalse : Question
    {
        public override string Header { get => "True Or False Question"; }

        public TrueOrFalse()
        {
        }
    

        public TrueOrFalse(string body, Answers[] answers)
        {
            Body = body;
            answers[0] = new Answers(1, "True");
            answers[1] = new Answers(2, "False");
            

        }



        public void CreateTorFQuestion()
        {


            Console.WriteLine(Header);



     

            Console.WriteLine("Enter Body of Question : ");

            Body = Console.ReadLine();





            double mark;

            do
            {
                Console.Write("Enter Mark Of Question :  ");
            }
            while ((!double.TryParse(Console.ReadLine(), out mark)) || (mark < 0));

            Mark = mark;








            int rightAnswer;

            do
            {
                Console.Write("Enter The Right Answer ( 1 .for true , 2. for false) : ");
            }
            while ((!int.TryParse(Console.ReadLine(), out rightAnswer)) || (rightAnswer <1 || rightAnswer>2));
            if (RightAnswer == null)
            {
                RightAnswer = new Answers();
            }
            RightAnswer.AnswerId = rightAnswer;
            if (rightAnswer == 1) 
            {
                RightAnswer.AnswerText = "True";
            
            
            }
            else
            {
                RightAnswer.AnswerText = "false";
            }



            List = new Answers[2];
            List[0] = new Answers(1, "True");
            List[1] = new Answers(2, "False");




            Console.Clear();




        }



    }
}

