using System.Threading.Channels;

namespace DZ_86
{
    internal class Program
    {    
        static int SumFromInt(int value)

        {
            if (value < 10)
                return value;// Если значенеие в будет меньше 10 то в числе осталось однозначное число
            
                int digit = value % 10; // Отделяем преведущую цифру чтобы сложить с предыдущей (1)
                int nextValue =value / 10;// При делении последняя цифра уберется (2)
            return  digit + SumFromInt(nextValue);//Складываем отделенную цифру (1) и результат выполнения функции передав
                                                  //туда значение последней цифры (2)
        }
        static void Main(string[] args)
        {
            SumFromInt(257);
        }
    }
}
