using Extantion_method_MyExtantion;//Лучше добавлять в отдельное пространство имен
namespace Extantion_method

{
    internal class Program
    {/* Extantiom method Медоды расширения позволяют добавлять функионал к уже существующим классам позволяют 
      добавлять етли даже у классов модификатор seald
        Методы расширения должны находиться в статическом классе и сами быть статическими */
        static void Main(string[] args)
        {
           DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();
            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Wednesday));  
        }
    }
}
