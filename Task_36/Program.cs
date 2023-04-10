// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();

Console.Write("Введите количество элементов массива: ");
int array = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[array];

void FillArray(int array1)
{
    for (int i = 0; i < array1; i++)
    {
        randomArray[i] = new Random().Next(1,99);
        Console.Write(randomArray[i] + " ");
    }

}

int SumOfOdd(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}

FillArray(array);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: { SumOfOdd(randomArray)}");