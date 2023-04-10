// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

Console.Write("Введите количество элементов массива: ");
int array = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[array];

void FillArray(int array)
{
    for (int i = 0; i < array; i++)
    {
        randomArray[i] = new Random().Next(99, 999);
        Console.Write(randomArray[i] + " ");
    }

}

int EvenNumbers(int[] randomArray)
{
    int count = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
            count = count + 1;
    }
    return count;
}

FillArray(array);
Console.Write($"\nКоличество чётных чисел в массиве: {EvenNumbers(randomArray)}");