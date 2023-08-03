// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число:");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Числа от {0} до 1:", N);
        PrintNumbers(N);
    }

    static void PrintNumbers(int N)
    {
        if (N >= 1)
        {
            Console.Write(N + " ");
            PrintNumbers(N - 1);
        }
    }
}
