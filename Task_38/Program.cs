// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int array = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[array];

void FillArray(int array)
{
    Random rand = new Random();
    for (int i = 0; i < array; i++)
    {
        randomArray[i] = rand.NextDouble();
        Console.Write($"{randomArray[i]:F2}");
    }

}

double DifferenseOfNumbers(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
        {
            max = randomArray[i];
        }
        if (min > randomArray[i])
        {
            min = randomArray[i];
        }
        i = i + 1;
    }
    return max - min;
}

FillArray(array);
Console.Write($"\nРазница между max и min элементов массива: {DifferenseOfNumbers(randomArray):F2}");
