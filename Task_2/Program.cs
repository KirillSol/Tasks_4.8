namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи количество строк: ");
            int line = int.Parse(Console.ReadLine());

            Console.WriteLine("Введи количество столбцов: ");
            int column = int.Parse(Console.ReadLine());

            int[,] arrayA = new int[line, column];
            int[,] arrayB = new int[line, column];

            Random random = new Random();

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arrayA[i, j] = random.Next(5);
                }
            }

            foreach (var matrixA in arrayA)
            {
                Console.Write(matrixA);
            }


            Console.WriteLine();


            for (int i = 0; i < line; i++)
            {
                for (int h = 0; h < column; h++)
                {
                    arrayB[i, h] = random.Next(5);
                }
            }
            foreach (var matrixB in arrayB)
            {
                Console.Write(matrixB);
            }


            Console.WriteLine();

            int[,] arrayC = new int[line, column]; // или можно int[,] arrayC = new int[arrayA.GetLength(0), arrayA.GetLength(1)]

            for (int i = 0; i < line; i++) // тогда вместо line будет arrayA.GetLength(0)
            {
                for (int j = 0; j < column; j++) // а вместо column > arrayA.GetLength(1)
                {
                    arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
                }
            }
            Console.WriteLine("\nСумма:");
            foreach (var item in arrayC)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}