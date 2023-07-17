using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG1_D7
{
    internal class TFQUESTIONS : Questions
    {
        #region constructor
        public TFQUESTIONS() : this(0)
        {
            // Console.WriteLine("TFQUESTIONS members(zero paramsters)");
        }
        public TFQUESTIONS(int num) : this(num, null)
        {
            // Console.WriteLine("TFQUESTIONS members(one paramters)");
        }
        public TFQUESTIONS(int num, string body) : this(num, body, 0)
        {
            // Console.WriteLine("TFQUESTIONS members(two paramters)");
        }
        public TFQUESTIONS(int num, string body, int mark) : base(num, body, mark)
        {
            // Console.WriteLine("TFQUESTIONS members(three paramters)");
        }
        #endregion

        public override string show()
        {
            string result = $"Question number is {Num}\n" +
               $"Question body is {Body}\n" +
                $"Question mark is {Mark}\n" +
                "True or False\n ";
            return result;
        }
        public override bool Equals(object? obj)
        {
            TFQUESTIONS t1 = (TFQUESTIONS)obj;
            return this.Num == t1.Num && this.Body == t1.Body && this.Mark == t1.Mark;
        }

    }
}