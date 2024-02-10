// Задача 2.2: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Clear();

void ShowEvenNumbers(int m, int n)
{
    if (m != n + 1)
    {
        if (m % 2 == 0)
        {
            Console.Write($"[{m}] ");
        }
        ShowEvenNumbers(m + 1, n);
    }
}

Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
while (m <= 0)
{
    Console.Write("Натуральные числа — это числа, которые используются при счёте (1, 2, 3 и т.д.). \nВведённое Вами число не является натуральным. \nВведите другое число: ");
    m = int.Parse(Console.ReadLine()!);
}
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);
while (n < m)
{
    Console.Write("Число N не может быть меньше числа M. Введите другое число: ");
    n = int.Parse(Console.ReadLine()!);
}
Console.Write($"Все чётные натуральные числа в промежутке от {m} до {n}: ");
ShowEvenNumbers(m, n);