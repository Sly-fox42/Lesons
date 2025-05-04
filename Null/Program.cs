using Microsoft.Win32.SafeHandles;
using System.Threading.Channels;

namespace Null
{
    internal class Program
    {   static int[] GetArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, };
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = GetArray();

            int num = 1;
            string str = "Hello";
            string str2= null;
            string strings = str + " " + (str2 ?? "Igor");//Оператор NULL оъединения если добавить = то ммы присвоим
            bool a= str == str2 ? true : false;   //Тернарный оператор                                         //премнной значение правого операнда

            Console.WriteLine(strings);
            Console.WriteLine("Сумма элемнетов в массиве равна "+ arr?.Sum());//Оператор условного null не
                                                                              //даст выполниться коду после ? (может использоваться
                                                                              //с оператором NULL оъединения).
       



        }
    }
}
