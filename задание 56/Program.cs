// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает суму элементов в каждой стрке и выдаёт номер стрки с наименшей суммой элементов: 1 строка

using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 4;
        int cols = 4;
        int[,] array = new int[rows, cols];

        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 11);
            }
        }

        Console.WriteLine("Исходный массив:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        int minRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < cols; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRow = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1} строка");
    }
}
