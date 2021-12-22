using System;


namespace UseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter operator");
            char op = Console.ReadLine().ToCharArray()[0];
            int? result = CaculatorLib.Calculator.Calc(num1, num2, op);
            if (result.HasValue)
            {
                Console.WriteLine($"\n{num1} {op}  {num2} = {result}");
            }
            Console.ReadLine();
        }
    }
}
