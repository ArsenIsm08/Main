// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//  элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };
        int m = 3;
        int n = 4;
         for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            BubbleSortRow(array, i);
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void BubbleSortRow(int[,] array, int row)
    {
        int cols = array.GetLength(1);

        for (int i = 0; i < cols - 1; i++)
        {
            for (int j = 0; j < cols - i - 1; j++)
            {
                if (array[row, j] < array[row, j + 1])
                {
                    int temp = array[row, j];
                    array[row, j] = array[row, j + 1];
                    array[row, j + 1] = temp;
                }
            }
        }
    }
}
