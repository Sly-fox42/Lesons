using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_58              /*Написать метод который выводит на экран строку. 
                             * Символы из которых состоит строка и их количество вводятся пользователем.*/
{
    internal class Program
    {   static void PrintString(char value,int quantity)
        {
            for (int i = 0; i < quantity; i++) {
                Console.WriteLine(value);
            }
           Console.Write("Символов выведено - " + quantity);
        }
        static char getChar()
        {
            Console.Write("Введите символ который хотите  распечатать ");
         return  Convert.ToChar(Console.ReadLine());
        }
        static int getQuantity() {
            Console.Write("Введите количество символов ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            PrintString(getChar(),getQuantity());
            
        }
    }
}
