using System.ComponentModel;

namespace Lesons
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int    a, b;
            Console.WriteLine("Введите число 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            b = Convert.ToInt32(Console.ReadLine());

            double c = (double)( a + b)/2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Результат равен: {c}");
            Console.ResetColor();

            // Результатом может быть  0 т.к. У int нет дробной части
        }
    }
}
