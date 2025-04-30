

namespace IfProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int firstValue =Convert.ToInt32(Console.ReadLine());
            if (firstValue % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else {
                Console.WriteLine("Число не четное");
            }
        }
    }
}
/* && || Можно использовать и по одиночке если проверяем результат выполнения функций (getAbc() | getDef */