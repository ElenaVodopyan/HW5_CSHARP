//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 100);
    }
    return numbers;
}

int OddSumm(int[] data)
{
    int summ = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if ((i + 1) % 2 != 0)
        {
            summ = summ + data[i];
        }
    }
    return summ;
}

int size = 6;
int[] numbers = FillArray(size);
Console.WriteLine("[{0}]", string.Join(", ", numbers));
Console.WriteLine($"{OddSumm(numbers)} -> сумма элементов, стоящих на нечётных позициях");
