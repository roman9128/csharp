// Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Console.Clear();
void PutRandomNumberTo(int[] array, int size, int from, int to, int i)
{
    if (i == size)
    {
        return;
    }
    else
    {
        array[i] = new Random().Next(from, to + 1);
        PutRandomNumberTo(array, size, from, to, i + 1);
    }
}
void Show(int[] array, int i = 0)
{
    if (i != array.Length)
    {
        Console.Write(array[i] + " ");
        Show(array, i + 1);
    }
}
void ShowReversed(int[] array, int i = 0)
{
    if (i != array.Length)
    {
        ShowReversed(array, i + 1);
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Вначале определим параметры массива");
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
while (to < from)
{
    Console.Write("Конечное число диапазона меньше начального. \nВведите другое число: ");
    to = int.Parse(Console.ReadLine()!);
}
int[] numbers = new int[size];
PutRandomNumberTo(numbers, size, from, to, 0);
Console.Write("Исходный массив:     ");
Show(numbers);
Console.WriteLine();
Console.Write("Перевёрнутый массив: ");
ShowReversed(numbers);