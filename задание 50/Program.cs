// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine()) - 1;

        int value = GetArrayElement(array, row, col);

        if (value != int.MinValue)
        {
            Console.WriteLine($"Значение элемента: {value}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет в массиве.");
        }
    }

    static int GetArrayElement(int[,] array, int row, int col)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        if (row >= 0 && row < rows && col >= 0 && col < cols)
        {
            return array[row, col];
        }

        return int.MinValue;
    }
}
             