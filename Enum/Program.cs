using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Friday,
        Saturday,
        Sunday

    }
    internal class Program
    {  
        static void Main(string[] args)
        {
            var value = 55;
            var  values =System.Enum.GetValues(typeof(DayOfWeek));
            DayOfWeek firstDayOfWeek = DayOfWeek.Monday;
            //Console.WriteLine(System.Enum.GetUnderlyingType(typeof(firstDayOfWeek)));
            Console.WriteLine(firstDayOfWeek.ToString());
            Console.WriteLine((DayOfWeek)3);
            Console.WriteLine(GetNextDay(DayOfWeek.Friday));
            DayOfWeek result = System.Enum.IsDefined(typeof(DayOfWeek), value) ? (DayOfWeek)value : (DayOfWeek)(value / 7) ;
            
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
           
        }

        static DayOfWeek GetNextDay(DayOfWeek dayOfWeek)
        {if(dayOfWeek < DayOfWeek.Sunday) 
                return dayOfWeek+1;
            return DayOfWeek.Monday;
        }

        // Enum Так же можно парсить 

   
}
}
