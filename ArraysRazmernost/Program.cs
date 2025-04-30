namespace ArraysRazmernost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int[][][] arrNums = new int[rnd.Next(2, 6)][][];
            for (int i = 0; i < arrNums.Length; i++)
            {
                arrNums[i] = new int[rnd.Next(2, 5)][];
                for (int j = 0; j < arrNums[i].Length; j++)
                {
                    arrNums[i][j] = new int[rnd.Next(2, 6)];
                    for (int k = 0; k < arrNums[i][j].Length; k++)
                    {

                        arrNums[i][j][k] = rnd.Next(100);
                    }
                }
            }

            for (int i = 0; i < arrNums.Length; i++)
            {
                for (int j = 0; j < arrNums[i].Length; j++)
                {
                    for (int k = 0; k < arrNums[i][j].Length; k++)
                    {
                        Console.Write($" "+arrNums[i][j][k]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
