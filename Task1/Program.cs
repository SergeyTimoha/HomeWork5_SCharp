using System;
using System.Linq;

Console.Clear();
int[] numbers = FillArray(10, 10, 999);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine($"Число чётных элементов в массиве: {EvenNumbers(numbers)}.");

int[] FillArray(int size, int mixValue, int maxValue)
{
    int[] getArray = new int[size].Select(x => new Random().Next(mixValue, maxValue + 1)).ToArray();
    return getArray;
}

int EvenNumbers(int[] numArray)
{
    int counter = numArray.Where(x => x % 2 == 0).Count();
    return counter;
}
