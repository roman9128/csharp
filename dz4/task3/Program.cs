// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

Console.Clear();
int[] PutRandomNumbersToArray()
{
    Console.Write("Размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
    while (size <= 0)
    {
        Console.Write("Размер массива должен быть более 0. Введите другое число: ");
        size = int.Parse(Console.ReadLine()!);
    }
    Console.Write("Начальное число диапазона: ");
    int from = int.Parse(Console.ReadLine()!);
    Console.Write("Конечное число диапазона: ");
    int to = int.Parse(Console.ReadLine()!);
    while (to < from)
    {
        Console.Write("Конечное число диапазона меньше начального. Введите другое число: ");
        to = int.Parse(Console.ReadLine()!);
    }
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}
int[] ReverseArray(int[] arr)
{
    int i = 0;
    int temp = 0;
    while (i < arr.Length / 2)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
        i++;
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("Начальный массив содержит следующие числа:    ");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
void PrintReversedArray(int[] arr)
{
    Console.Write("Перевёрнутый массив содержит следующие числа: ");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
int[] numbers = PutRandomNumbersToArray();
PrintArray(numbers);
Console.WriteLine();
PrintReversedArray(ReverseArray(numbers));