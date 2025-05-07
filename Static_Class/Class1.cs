using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    internal  class Class1 //Если класс будет статическим то не нужно будет создавать экземпляр этого класса
                           //Конструктор класса может быть вызван один раз при первом обращеннии к этому классу
    {
        static int x; //Статические поля класса могут вызываться в статических и  нестатических методах
        static void Foo()
        {
            x = 5;
            Console.WriteLine("Вызван метод Foo"  + x);
        }
        public void Bar()
        {   x = 6;
            Console.WriteLine("Вызван метод Bar" + x);
            Foo();// Нестатическике методы могут вызывать статические но не наоборот
        }
    }
}
