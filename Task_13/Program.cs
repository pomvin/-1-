// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число:");
int nam = int.Parse(Console.ReadLine()!);

while (nam > 999)
{
    nam = nam / 10;
}
if (nam < 99)
{
    Console.WriteLine("Третей цифры нет!");
}
else
{
    nam = nam % 10;
    Console.WriteLine(nam);
}