// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);
int sum = numberA;


for(int i = 1; i < numberB; i++)
{
    sum = sum * numberA;
}

Console.WriteLine("A в степени B равно: " + sum);
