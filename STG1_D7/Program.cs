namespace STG1_D7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MCQ m1 = new MCQ(3, "who is the current president of america?", 5, new string[] { "biden", "tramp", "obama" });
            Console.WriteLine(m1.ToString());
            MCQ m2 = new MCQ(3, "who is the current president of america?", 5, new string[] { "biden", "tramp", "obama" });
            Console.WriteLine(m2.ToString());
            Console.WriteLine(m1.Equals(m2));

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            TFQUESTIONS t1 = new TFQUESTIONS(1, "Egypt has 25 governorates?", 10);
            Console.WriteLine(t1.ToString());
            TFQUESTIONS t2 = new TFQUESTIONS(2, "Egypt has 25 governorates?", 10);
            Console.WriteLine(t2.ToString());
            Console.WriteLine(t1.Equals(t2));
        }
    }
}