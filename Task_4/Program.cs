// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа : ");
int nam1, nam2, nam3;
nam1 = Convert.ToInt32(Console.ReadLine());
nam2 = Convert.ToInt32(Console.ReadLine());
nam3 = Convert.ToInt32(Console.ReadLine());
int max = nam1;

if (max < nam2) max = nam2;
if (max < nam3) max = nam3;

System.Console.WriteLine($"Максимальное из этих чисел = {max}");

// if (A >= B)
// {
//     if (A >= C)
//     {
//         Console.WriteLine($"Максимальное число {A}");
//     }
// }
// else if (C >= B)
// {
//     Console.WriteLine($"Максимально число {C}");
// }
// else
// {
//     Console.WriteLine($"Максимальное число {B}");
// }


