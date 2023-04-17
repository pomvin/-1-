// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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
            arr[i, j] = new Random().Next(1, 100);
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

Console.WriteLine("Среднее арифметическое значение каждого столбца равно: ");

for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = (sum + arr[i, j]);
    }
    sum = sum / row;
    Console.Write($"{Math.Round(sum, 1)}");
    if (j != arr.GetLength(1) - 1) Console.Write("; ");
}