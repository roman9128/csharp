// Напишите программу, которая заполнит массив простыми числами и выдаст количество простых чисел

Console.Clear(); // Очищаю консоль

int[] numbers = PutRandomNumbersToArray(); // ввожу массив и запрашиваю данные для него из функции

// Функция по определению параметров массива и заполнению его случайными числами
int[] PutRandomNumbersToArray()
{
    // Определяем размер массива
    Console.Write("Размер массива от 1 до 8: ");
    int size = int.Parse(Console.ReadLine()!);
    while (size <= 0 || size > 8)
    {
        Console.Write("Размер массива должен быть от 1 до 8. Введите другое число: ");
        size = int.Parse(Console.ReadLine()!);
    }
    // Определяем начальное число диапазона
    Console.Write("Начальное число диапазона от 0 до 9: ");
    int from = int.Parse(Console.ReadLine()!);
    while (from < 0 || from > 9)
    {
        Console.Write("Начальное число диапазона должно быть от 0 до 9. Введите другое число: ");
        from = int.Parse(Console.ReadLine()!);
    }
    // Определяем конечное число диапазона
    Console.Write("Конечное число диапазона: ");
    int to = int.Parse(Console.ReadLine()!);
    while (to < from)
    {
        Console.Write("Конечное число диапазона меньше начального. Введите другое число: ");
        to = int.Parse(Console.ReadLine()!);
    }
    while (to < 0 || to > 9)
    {
        Console.Write("Конечное число диапазона должно быть от 0 до 9. Введите другое число: ");
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

// Функция для склеивания цифр массива в одно число математически
int GlueDigits(int[] arr)
{
    int i = 0;
    int number = 0;
    while (i < arr.Length)
    {
        number = number * 10 + arr[i];
        i++;
    }
    return number;
}
// Функция для склеивания чисел массива в одно число
long GlueNumbers(int[] arr)
{
    string num = "";
    foreach (var e in arr)
    {
        num += e;
    }
    return long.Parse(num);
}
long gluednumbers = GlueNumbers(numbers);

PrintArray(numbers);
Console.WriteLine();
Console.Write("Склеенное число из чисел массива: " + gluednumbers);