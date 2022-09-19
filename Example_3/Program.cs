// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray(int size)
{
    double[] numbers = new double[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-99, 100);
    }
    return numbers;
}

double MaxMinDiff(double[] data)
{
    double max = data[0];
    double min = data[0];

    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] > max)
        {
            max = data[i];
        }
        if (data[i] < min)
        {
            min = data[i];
        }
    }
    return max - min;
}

int size = 5;
double[] numbers = FillArray(size);
Console.WriteLine("[{0}]", string.Join(", ", numbers));
Console.WriteLine($"{MaxMinDiff(numbers)} -> разница между максимальным и минимальным элементом массива");