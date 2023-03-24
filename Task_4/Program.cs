// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа : ");
int A, B, C;
A = Convert.ToInt32(Console.ReadLine());
B = Convert.ToInt32(Console.ReadLine());
C = Convert.ToInt32(Console.ReadLine());

if (A >= B)
{
    if (A >= C);
    {
        Console.WriteLine($"Максимальное число {A}");
    }
}
else if (C >= B)
{
    Console.WriteLine($"Максимально число {C}");
}
else
{
    Console.WriteLine($"Максимальное число {B}");
}


