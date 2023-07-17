using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG1_D7
{
    internal class MCQ : Questions
    {
        private string[] answers;
        public string[] Answers
        {
            get { return answers; }
            set { answers = value; }
        }
        #region contructors
        public MCQ() : this(0)
        {
            //  Console.WriteLine("Mcq members(zero paramsters)");
        }
        public MCQ(int num) : this(num, null)
        {
            //Console.WriteLine("Mcq members(one paramters)");
        }
        public MCQ(int num, string body) : this(num, body, 0)
        {
            //Console.WriteLine("Mcq members(two paramters)");
        }
        public MCQ(int num, string body, int mark) : base(num, body, mark)
        {
            // Console.WriteLine("Mcq members(three paramters)");
        }
        public MCQ(int num, string body, int mark, string[] answers) : base(num, body, mark)
        {
            // Console.WriteLine("Mcq members(four paramters)");
            Answers = answers;
        }
        #endregion
        public override string show()
        {

            string result = $"Question number is {Num}\n" +
               $"Question body is {Body}\n" +
                $"Question mark is {Mark}\n" +
                "Question answers are\n ";

            if (answers != null)
            {
                for (int i = 0; i < Answers.Length; i++)
                {
                    result = result + Answers[i] + "  ";
                }


            }
            return result;

        }
        public override string ToString()
        {
            string result = $"Question number is {Num}\n" +
               $"Question body is {Body}\n" +
                $"Question mark is {Mark}\n" +
                "Question answers are\n ";

            if (answers != null)
            {
                for (int i = 0; i < Answers.Length; i++)
                {
                    result = result + Answers[i] + "  ";
                }


            }
            return result;
        }
        public override bool Equals(object? obj)
        {
            MCQ m1 = (MCQ)obj;
            bool IsEqual = false;
            for (int i = 0; i < this.Answers.Length; i++)
            {
                if (this.Answers[i] != m1.Answers[i])
                    break;
                else
                    IsEqual = true;
            }
            return this.Num == m1.Num && this.Body == m1.Body && this.Mark == m1.Mark && IsEqual == true;

        }
    }
}