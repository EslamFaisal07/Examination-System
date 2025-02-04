using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    internal abstract class Question
    {


        public virtual string? Header { get; set; }
        public string? Body { get; set; }

        public double Mark { get; set; }
        public Answers[]? List { get; set; }
     
        public Answers? RightAnswer { get; set; }
        public Answers? UserAnswer { get; set; }






        public Question()
        {
        }
      





  





        override public string ToString()
        {
            return $"{Header}\n {Body} (Mark: {Mark})";
        }






    }
}
