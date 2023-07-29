// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] array = new int[2, 2, 2];
        Random random = new Random();

        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    int num;
                    do
                    {
                        num = random.Next(10, 100);
                    } while (IsNumberUsed(array, num));

                    array[x, y, z] = num;
                }
            }
        }

        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
                }
                Console.WriteLine();
            }
        }
    }

    static bool IsNumberUsed(int[,,] array, int num)
    {
        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    if (array[x, y, z] == num)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
