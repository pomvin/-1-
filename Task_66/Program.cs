﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbersRange(int m, int n)
{ 
    if (m == n) return n;
    else return m + SumNaturalNumbersRange(m +1, n);
}

Console.Write($"Сумма натуральных элементов в промежутке от М до N: {SumNaturalNumbersRange(num1, num2)}");

