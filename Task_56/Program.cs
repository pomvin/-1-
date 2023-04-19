// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 9);
        }
    }
}

Console.Clear();

Console.Write("Введите колличество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine()!);

int[,] arr = new int[row, column];
FillArray(arr);
Console.WriteLine("Массив: ");
PrintArray(arr);

int SumLine(int[,] arr, int i)
{
    int sum = arr[i, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
    if (sum > SumLine(arr, i))
    {
        sum = SumLine(arr, i);
        minSum = i + 1;
    }
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: { minSum}");