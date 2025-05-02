namespace DZ_70
{
    internal class Program
    {

        static int[] ResizeArr(ref int[] array)
        { 
            int newSize;
            Console.Write("Введите новый размер массива: ");
           newSize =int.Parse(Console.ReadLine());  
            int [] newArray = new int[newSize];

            for (int i = 0; i <array.Length && i< newSize; i++) {
                newArray[i] = array[i];
            }
              
           return array = newArray;
        }
        static void Main(string[] args)
        {
            int[] arr = { 3,58,899,8,
            40};

            ResizeArr(ref arr);
            Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] +" ");
            }

            Console.WriteLine(arr.Length);
        }
    }
}
