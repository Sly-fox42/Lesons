namespace DZ_74
{
    internal class Program
    {
        static void RemoveToArray(ref int[] array,  int index)
        {
            int[] newArray = new int[array.Length -1];

           
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];

            }
            for (int i = index+1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;
        }

        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, };
             RemoveToArray(ref array1, 2);
        }
    }
}
