// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> tакого числа в массиве нет

Console.Clear();

Console.Write("Введите колличество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine()!);
int [,] randomArray = new int [row, column];
Console.Write("Введите позицию строки: ");
int positRow = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию столбца: ");
int positColumn = int.Parse(Console.ReadLine()!);


void FillArray(int row, int column)
{
    int i, j;
    for (i = 0; i < row; i++)
    {
        Console.WriteLine();
        for (j = 0; j < column; j++)
        {
            randomArray[i, j] = new Random().Next(1,99);
            Console.Write($"{ randomArray[i, j]} ");
}
Console.WriteLine();
}
}
void PrintArray ()
{
    if (positRow < 1 || positColumn < 1)
    Console.Write("Позиции строк не могут быть отрицательными");
else if (positRow <= row + 1 && positColumn <= column + 1)
    Console.Write($"Значение элемента равно { randomArray[positRow - 1, positColumn - 1]} ");
else Console.Write("Такого элемента нет в массиве");
}

FillArray(row, column);
PrintArray();
// if (positRow < 1 || positColumn < 1)
//     Console.Write("Позиции строк не могут быть отрицательными");
// else if (positRow <= row + 1 && positColumn <= column + 1)
//     Console.Write($"Значение элемента равно { randomArray[positRow - 1, positColumn - 1]:F2} ");
// else Console.Write("Такого элемента нет в массиве");