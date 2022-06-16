using System;
using System.Linq;

Console.Clear();
int[] numbers = FillArray(10, 0, 99);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine($"Разность максимального и минимального элементов массива: {Max(numbers) - Min(numbers)}.");

int[] FillArray(int size, int mixValue, int maxValue)
{
    int[] getArray = new int[size].Select(x => new Random().Next(mixValue, maxValue + 1)).ToArray();
    return getArray;
}

int Min(int[] numArr)
{
    int min = numArr.Min();
    return min;
}

int Max(int[] numArray)
{
    int max = numArray.Max();
    return max;
}