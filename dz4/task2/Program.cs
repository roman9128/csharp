// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

Console.Clear();
int[] PutRandomNumbersToArray()
{
    Console.Write("Размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
    while (size <= 0)
    {
        Console.Write("Размер массива должен быть больше 0. Введите другое число: ");
        size = int.Parse(Console.ReadLine()!);
    }
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("Массив содержит следующие числа: ");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
int CountEvenNumbers(int[] arr)
{
    int count = 0;
    foreach (int e in arr)
    {
        if (e % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] numbers = PutRandomNumbersToArray();
int cnt = CountEvenNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.Write($"Количество чётных чисел в данном массиве: {cnt}");