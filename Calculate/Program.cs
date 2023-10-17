using System.Diagnostics.CodeAnalysis;

namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string operation;

            Console.Write("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Введите операцию(+ - * /): ");
            operation = Console.ReadLine();

            Console.Write("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());

            

            if(operation == "+")
            {
                Console.WriteLine($"{a} + {b} = { sum(a, b) }");
            }
            if (operation == "-")
            {
                Console.WriteLine($"{a} - {b} = {diff(a, b)}");
            }
            if (operation == "*")
            {
                Console.WriteLine($"{a} * {b} = {mult(a, b)}");
            }
            if (operation == "/")
            {
                Console.WriteLine($"{a} / {b} = {div(a, b)}");
            }
        }


        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int diff(int a, int b)
        {
            return a - b;
        }

        public static int mult(int a, int b)
        {
            return a * b;
        }

        public static int div(int a, int b)
        {
            return a / b;
        }
    }
}
