using System.Threading.Channels;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondValue = double.Parse(Console.ReadLine());
            double result;
            Console.WriteLine("Введите действие с числами");
            string action = Console.ReadLine();
            // switch (action)
            // {
            //     case "+":
            //         result = firstValue + secondValue;
            //         Console.WriteLine(result);
            //         break;case "-":
            //          result = firstValue - secondValue;
            //         Console.WriteLine(result);
            //         break;case "*":
            //          result = firstValue * secondValue;
            //         Console.WriteLine(result);
            //         break;case "/":
            //          result = firstValue / secondValue;
            //         Console.WriteLine(result);
            //         break;
            //     default:Console.WriteLine("Вы ввели не коретные данные");
            //         break;
            // }


            if (action == "+")
            {
                result = firstValue +secondValue;
                Console.WriteLine(result);
            }
            if (action == "-")
            {
                result = firstValue - secondValue;
                Console.WriteLine(result);
            }
            if (action == "*")
            {
                result = firstValue / secondValue;
                Console.WriteLine(result);
            }
            if  (action == "/")
            {
                result = firstValue / secondValue;
                Console.WriteLine(result);
            }
            else  Console.WriteLine("некоректные данные");
          


             

        }
    }
}
