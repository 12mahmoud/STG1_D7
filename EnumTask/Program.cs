namespace EnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int d;
            bool IsValid = false;

            while (!IsValid)
            {
                Console.WriteLine("Enter day number ");
                d = int.Parse(Console.ReadLine());
                switch (d)
                {
                    case 1:
                        Console.WriteLine(Days.Saturday.ToString());
                        IsValid = true;
                        break;

                    case 2:
                        Console.WriteLine(Days.Sunday.ToString());
                        IsValid = true;

                        break;
                    case 3:
                        Console.WriteLine(Days.Monday.ToString());
                        IsValid = true;
                        break;
                    case 4:
                        Console.WriteLine(Days.Tuesday.ToString());
                        IsValid = true;
                        break;
                    case 5:
                        Console.WriteLine(Days.Wednesday.ToString());
                        IsValid = true;
                        break;
                    case 6:
                        Console.WriteLine(Days.Thursday.ToString());
                        IsValid = true;
                        break;
                    case 7:
                        Console.WriteLine(Days.Friday.ToString());
                        IsValid = true;
                        break;
                    default:
                        Console.WriteLine("invalid number");
                        IsValid = false;
                        break;
                }
            }
        }
    }
}