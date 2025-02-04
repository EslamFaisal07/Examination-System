using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    internal class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Exam Exam { get; set; }




        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
       
        }



        public void CreateExam()
        {


            int result;
            do
            {
                Console.Write("Please Enter Type of Exam (1. for Practical , 2.for Final) :  ");
            }
            while ((!int.TryParse(Console.ReadLine(), out result)) || (result != 1 && result != 2));


            int time;
            do
            {
                Console.Write("Please Enter The Time Of Exam in Minutes :  ");
            }
            while ((!int.TryParse(Console.ReadLine(), out time)) || (time < 0));


            int NoOfQuestions;
            do
            {
                Console.Write("Please Enter The Number Of Questions :  ");
            }
            while ((!int.TryParse(Console.ReadLine(), out NoOfQuestions)) || (NoOfQuestions < 0));
            Console.Clear();

            if (result == 1)
            {
                Exam = new PracticalExam(time, NoOfQuestions);
                Exam.CreateExam();
                
            }
            else
            {
                Exam = new FinalExam(time, NoOfQuestions);
                Exam.CreateExam();
                
            }



        }



        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}";
        }


    }
}
