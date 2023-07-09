namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи количество строк: ");
            int line = int.Parse(Console.ReadLine());

            Console.WriteLine("Введи количество столбцов: ");
            int column = int.Parse(Console.ReadLine());

            int[,] array = new int[line, column];

            Random random = new Random();

            for (int i = 0; i < line; i++)
            {
                int sum = 0;
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = random.Next(10);
                    Console.Write($" {array[i, j]} ");
                    sum += array[i, j];
                }
                Console.WriteLine($" Сумма: {sum}");
            }
            Console.WriteLine();
        }
    }
}