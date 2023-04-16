// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);

Console.Write("Введите max число строк: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите min число столбцов: ");
int stop = int.Parse(Console.ReadLine()!);

double[,] arr = new double[row, column];
FillArrayRandomNumbers(arr);
PrintArray(arr);


void FillArrayRandomNumbers(double[,] arr)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        Console.Write("[");
        for (int j = 0; j < column; j++)
        {
            Console.Write($" {arr[i, j]} ");         
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

