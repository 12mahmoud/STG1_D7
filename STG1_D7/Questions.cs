using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STG1_D7
{
    internal abstract class Questions
    {
        private int num;
        private string body;
        private int mark;
        #region constructors
        public Questions() : this(0)
        {
            //  Console.WriteLine("Questions members (zero parameters)");
        }
        public Questions(int num) : this(num, null)
        {
            // Console.WriteLine("Questions members (one parameters)");
        }
        public Questions(int num, string body) : this(num, body, 0)
        {
            // Console.WriteLine("Questions members (two parameters)");
        }
        public Questions(int num, string body, int mark)
        {
            //Console.WriteLine("Questions members (three parameters)");
            this.num = num;
            this.body = body;
            this.mark = mark;
        }
        #endregion
        #region properties
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public string Body
        {
            get { return body; }
            set { body = value; }
        }
        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        #endregion
        public abstract string show();
        public override string ToString()
        {
            return $"Number: {num} " + $"Question: {body} " + $"Mark: {mark} ";
        }


    }

}