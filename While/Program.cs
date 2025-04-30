namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение диапазона");
            int startValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение диапазона");
            int finalValue  = int.Parse(Console.ReadLine());
            int temp = startValue;
            int ch = 0, nch = 0;
            while (temp <= finalValue) {
               
                if (temp % 2 == 0) {
                    ch++;
                }
                else { 
                nch++;
                }
                temp++; 
                
            }
            Console.WriteLine("Колличество четных чисел  равно " + ch);
            Console.WriteLine("Колличество нечетных чисел  равно " + nch);
        }
    }
}


/* Написать программу которая будет подсчитывать количество чётных и нечётных чисел в диапазоне указанном пользователем. 
 * Под диапазоном подразумевается первое и последнее число например 3 и 78
 */