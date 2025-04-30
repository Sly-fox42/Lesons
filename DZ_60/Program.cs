using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_60
{                                    /* Написать метод для поиска индекса элемента массива (тип элементов в массиве - int).
                                    * Метод должен вернуть индекс первого найденного элемента. 
                                    * Если элемент в массиве не найден - метод возвращает -1.*/
    internal class Program

    {
        static Random random = new Random();
        static int findElementIndex(int[] arr,int value)
        {
            
            for (int i = 0; i < arr.Length; i++) {
                if(arr[i] == value) return i;
               ;
            }
            return -1 ;
        }

   
        static void Main(string[] args)

        {
            int[] nums = new int[random.Next(2,20)];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 50);
            }
            
            Console.WriteLine(findElementIndex(nums, random.Next(1,20)));
        }
    }
}
