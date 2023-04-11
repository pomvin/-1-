// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void FillArray(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите { i + 1} элемент массива" ); // Вводится нужное количесство элементов массива М
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int SumOfPositive(int[] Array)
{
    int i = 0;
    int sum = 0;
    while (i < Array.Length)
    {
        if (Array[i] > 0)
            sum = sum + 1;
        i = i + 1;
    }
    return sum;
}

FillArray(m);
Console.Write($"\n Чисел больше нуля: { SumOfPositive(Array)}");
