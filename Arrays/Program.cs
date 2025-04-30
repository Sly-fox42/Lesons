namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {11,3,4,88,878,4,1,77,42,4,11,86};
            int minValue = 0;
            Console.WriteLine("Введите пять цифр");

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("Введите элемнет под номером " + i + ":");
            //    nums[i] = int.Parse(Console.ReadLine());
            //}


            // Вывод в обратном порядке
            //for (int i = (nums.Length-1); i >=0; i--) {
            //    Console.WriteLine(nums[i]);
            //}


            // Вывод суммы четных чисел
            //int  sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{

            //    if (nums[i] % 2 == 0)
            //    {
            //        sum += nums[i];
            //    }
            //    else continue;

            //}
            //Console.WriteLine(sum);

            // Вывод минимаьного значения в массиве

            //minValue = nums[0];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] < minValue)
            //    {
            //        minValue = nums[i];

            //    }
            //    else continue;
            //}
            //Console.WriteLine($"Минимальное значение в массиве: {minValue}");



            //int result =nums.Where(i=>i%2 ==0).Sum();
            int [] unic =nums.Distinct().ToArray(); //  Уникальные значения в новый массив
            int [] orderMin=nums.OrderBy(x => x).ToArray();// по возрастанию
            int [] orderMax=nums.OrderByDescending(x => x).ToArray();// по убыванию


            // Класс Array тоже имеет свои методы 
           int ind = Array.FindIndex(nums,i=>i == 4);
            Console.WriteLine(ind);
        }
            
    }
}
