// Напишите программу, которая заполнит массив простыми числами и выдаст количество простых чисел

Console.Clear(); // Очищаю консоль
int[] numbers = PutRandomNumbersToArray(); // ввожу массив и запрашиваю данные для него из функции

// Функция по определению параметров массива и заполнению его случайными числами
int[] PutRandomNumbersToArray()
{
    Console.Write("Размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
    while (size <= 0)
    {
        Console.Write("Размер массива меньше либо равен нулю. Введите другое число: ");
        size = int.Parse(Console.ReadLine()!);
    }

    Console.Write("Начальное число диапазона: ");
    int from = int.Parse(Console.ReadLine()!);

    Console.Write("Конечное число диапазона: ");
    int to = int.Parse(Console.ReadLine()!);
    while (to <= from)
    {
        Console.Write("Конечное число диапазона меньше либо равно начальному. Введите другое число: ");
        to = int.Parse(Console.ReadLine()!);
    }
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}

// Функция по выводу чисел массива
void PrintArray(int[] arr)
{
    Console.Write("Массив содержит следующие числа: ");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

// Функция, позволяющая определить соответствие числа заданным требованиям
static bool IsOK(int number)
{
    if (number % 10 == 1 && number % 7 == 0)
    {
        return true;
    }
    return false;
}

// Функция, подсчитывающая количество чисел в массиве, соответствующих заданным требованиям
int CountNumbers(int[] arr)
{
    int count = 0;
    foreach (int e in arr)
    {
        if (IsOK(e))
        {
            count++;
        }
    }
    return count;
}

int count_of_OK_numbers = CountNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.Write("Количество подходящих чисел в массиве: " + count_of_OK_numbers);