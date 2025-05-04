namespace DZ_82_Recursive_Out_Array
{
    internal class Program
    {
      static  int i = 0;
        static int sum = 0;
        static int OutArray(int[] array)
        {

            if (i < array.Length)
            {

                Console.WriteLine(array[i]);
               
               
                sum += array[i];
                i++;
                OutArray(array);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            ;
            int[] arr = { 1, 2, 3, 4};
            Console.WriteLine( OutArray(arr));
        }
    }
}
