// Напишите программу, которая заполнит массив простыми числами и выдаст количество простых чисел

// Определяем параметры массива
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
int[] numbers = PutRandomNumbersToArray(size, from, to); // передал в новый массив данные из функции

// Функция по заполнению массива случайными числами
int[] PutRandomNumbersToArray(int size, int from, int to)
{
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

// Функция по выводу простых чисел массива
void PrintSimpleNumbers(int[] arr)
{
    Console.Write("Простыми числами в данном массиве являются: ");
    foreach (int e in arr)
    {
        if (IsSimple(e))
            {
                Console.Write($"{e} ");
            }
    }
}

// Функция, позволяющая определить, является ли число простым
static bool IsSimple(int number)
{
    if (number < 2)
    {
        return false;
    }
    for (int i = 2; i*i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}

// Функция, подсчитывающая количество чисел в массиве, соответствующих заданным требованиям
int CountNumbers(int[] arr)
{
    int count = 0;
    foreach (int e in arr)
    {
        if (IsSimple(e))
        {
            count++;
        }
    }
    return count;
}

int count_of_simple_numbers = CountNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
PrintSimpleNumbers(numbers);
Console.WriteLine();
Console.Write("Количество простых чисел в массиве: " + count_of_simple_numbers);