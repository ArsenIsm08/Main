// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3



class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        double[] averageColumnValues = new double[cols];

        // Вычисляем среднее арифметическое элементов в каждом столбце
        for (int j = 0; j < cols; j++)
        {
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }

            averageColumnValues[j] = (double)sum / rows;
        }

        // Выводим среднее арифметическое для каждого столбца
        Console.WriteLine("Среднее арифметическое каждого столбца:");

        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{averageColumnValues[j]:F1} ");
        }
    }
}
