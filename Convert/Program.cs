using System;
using System.Globalization;
namespace Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {NumberFormatInfo nfi = new NumberFormatInfo() { // Создаем экземпляр объекта NFI и определяем разделитель
               NumberDecimalSeparator = ".", 
            };

            string a = "52.1";
            double b = System.Convert.ToDouble(a,nfi); // Добавляем вторым аргументом определенный разделиттель при конвертации
            Console.WriteLine(b+3);
            int.TryParse(a, out int n);
            /* 
            Так же существуют методы 
             Parse и TryParse
             int.Parse  Метод у которого вызываем Parse(в него в дальнейшем и преобразуем строку, в данном случае int)
             int.TryParse(a, out int n); Принимает строку из которой нужно извлечь данные, переменую того типа в которыый необходимо поместить данные
            можно будет добавить условие   и TryParse вернет true если удалось конвртировать
            Если  Прилетает Исключение Format нужно использовать try catch или


             */

        }
    }
}
