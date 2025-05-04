using System;

namespace DZ_72
{
    internal class Program
    {
        static void AddToStartArray(ref int[] array,int value)
        {
            AddToArray(ref array, value,0);

        }

        static void AddToEndArray( ref int[] array, int value)
        {
            AddToArray(ref array, value, array.Length);
        }

        static void AddToArray(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = value;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];

            }
            for (int i = index; i < array.Length; i++)
            {
                newArray[i+1] = array[i];
            }
            array = newArray;
        }

        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, };

            AddToStartArray(ref array1, 10);
            AddToEndArray(ref array1, 11);
            AddToArray(ref array1 , 12,3);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }
    }
}
