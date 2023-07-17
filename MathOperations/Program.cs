namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Select the operation you want");
                string s = Console.ReadLine();
                if (s == "exit")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Enter num 1");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter num 2");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter num 3");
                    int n3 = int.Parse(Console.ReadLine());

                    switch (s)
                    {
                        case "add":
                            Console.WriteLine($"{n1}= " + MyMath.add(n1));
                            Console.WriteLine($"{n1}+{n2}=  " + MyMath.add(n1, n2));
                            Console.WriteLine($"{n1}+{n2}+{n3}=  " + MyMath.add(n1, n2, n3));
                            break;
                        case "substract":
                            Console.WriteLine($"{n1}= " + MyMath.substract(n1));
                            Console.WriteLine($"{n1}-{n2}=  " + MyMath.substract(n1, n2));
                            Console.WriteLine($"{n1}-{n2}-{n3}=  " + MyMath.substract(n1, n2, n3));
                            break;
                        case "multiply":
                            Console.WriteLine($"{n1}= " + MyMath.mul(n1));
                            Console.WriteLine($"{n1}*{n2}= " + MyMath.mul(n1, n2));
                            Console.WriteLine($"{n1}*{n2}*{n3}= " + MyMath.mul(n1, n2, n3));
                            break;
                        case "divide":
                            try
                            {
                                Console.WriteLine($"{n1}= " + MyMath.div(n1));
                                Console.WriteLine($"{n1}/{n2}= " + MyMath.div(n1, n2));
                                Console.WriteLine($"{n1}/{n2}/{n3}= " + MyMath.div(n1, n2, n3));

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "reminder":
                            Console.WriteLine($"{n1}= " + MyMath.reminder(n1));
                            Console.WriteLine($"{n1}%{n2}= " + MyMath.reminder(n1, n2));

                            break;
                        default:
                            Console.WriteLine("NOT avaliable action");
                            break;
                    }


                }
            }
        }




    }
    class MyMath
    {
        public static int add(int x, int y = 0, int z = 0) { return x + y + z; }
        public static int substract(int x, int y = 0, int z = 0) { return x - y - z; }
        public static int mul(int x, int y = 1, int z = 1) { return x * y * z; }
        public static double div(int x, int y = 1, int z = 1)
        {
            if (y != 0 && z != 0)
            {
                return (double)x / y / z;
            }
            else
            {
                throw new DivideByZeroException("Error: Division by zero!");
            }

        }
        public static int reminder(int x, int y = 1) { return x % y; }
    }

}