namespace BigLevelArrays
{
    internal class Program
    {// Прямоугольные массивы
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,,] arr3D;
            arr3D = new int[2,3,5];
            for (int i = 0; i < arr3D.GetLength(0); i++) {// Перебираем внешний уровень массива
              
                for (int j = 0; j < arr3D.GetLength(1); j++)
                {// Перебираем средний уровень массива

                    for (int k = 0; k < arr3D.GetLength(2); k++) {// Перебираем элементы массива
                        arr3D[i, j, k] = random.Next(100);
                    }
                }
            }




            for (int i = 0; i < arr3D.GetLength(0); i++) {
                Console.WriteLine($"Вывод страницы {i +1}");
                for (int j = 0; j < arr3D.GetLength(1); j++) {
                    Console.Write($"Строка  {j+1}\t");
                    for (int k = 0; k < arr3D.GetLength(2); k++) {
                        Console.Write(arr3D[i, j, k] + "\t");

                    }
                    Console.WriteLine();

                }

                Console.WriteLine();

            }
            

        }
    }
}
