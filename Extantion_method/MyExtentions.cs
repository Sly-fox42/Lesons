using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extantion_method_MyExtantion
{
   static class MyExtentions
    {
        public static void Print(this DateTime date) // Метод должен принять первым параметром тип данных для которого пишем  метод
        {
            Console.WriteLine(date);
        }

        static public bool IsDayOfWeek(this DateTime date , DayOfWeek dayOfWeek) { 
        return date.DayOfWeek == dayOfWeek;
        }
    }
}
