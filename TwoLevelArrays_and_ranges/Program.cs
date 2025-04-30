namespace TwoLevelArrays_and_ranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //    int[] arr2 = arr[1..4];
            //    Index myIndex = ^1;
            //    Index myIndex2 = new Index(3, true);
            //    Range myRange = new Range(myIndex, myIndex2);// Диапазон
            //    Console.WriteLine($"Value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");
            //    Console.WriteLine(arr2);
            //    Console.WriteLine(arr[myIndex2]);//получаем элемент с конца массива


            string[,] table = new string[3, 5]
         {
             {"Name", "Igor", "Elena", "Vadim", "Irina" },
             { "Age", "25", "11", "42", "35"},
             {"City", "Moscow", "St.Piterburg", "Yurga", "Kemerovo" }
         };

            // 1. Определяем ширину каждого столбца
            int[] columnWidths = new int[table.GetLength(1)];// Создаем массив чисел размером равным количеству элементтов во внутреннем массиве
            for (int j = 0; j < table.GetLength(1); j++)
            {
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    columnWidths[j] = Math.Max(columnWidths[j], table[i, j].Length);/*
В итоге, строка columnWidths[j] = Math.Max(columnWidths[j], table[i, j].Length); делает следующее:


Получает текущую ширину колонки j:  Берет значение, которое уже хранится в columnWidths[j].  Это текущая "лучшая" (максимальная) ширина,
известная для этой колонки на данный момент.

Вычисляет ширину ячейки table[i, j]:  Определяет длину строки, находящейся в ячейке таблицы на строке i и колонке j.

Сравнивает и обновляет: Сравнивает текущую ширину колонки (columnWidths[j]) с длиной строки в текущей ячейке (table[i, j].Length). 
Если длина строки в ячейке больше, чем текущая ширина колонки, то columnWidths[j] обновляется, чтобы хранить эту новую, большую ширину.
В противном случае, columnWidths[j] остается без изменений.


                                                                                     */
                }
            }

            // 2. Печатаем таблицу с форматированием
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j].PadRight(columnWidths[j] + 3)); // PadRight добавляет пробелы справа
                }
                Console.WriteLine();
            }


        }
    }
}
