// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = CalculateSum(M, N);
        Console.WriteLine("Сумма натуральных элементов от {0} до {1}: {2}", M, N, sum);
    }

    static int CalculateSum(int M, int N)
    {
        if (M > N)
        {
            return 0;
        }
        else
        {
            return M + CalculateSum(M + 1, N);
        }
    }
}
