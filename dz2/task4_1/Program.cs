﻿//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
Console.Write("Введите натуральное число, а я покажу его цифры: ");
int n = int.Parse(Console.ReadLine()!);
while (n > 9)
    {
    Console.Write(n % 10 + ", ");
    n = n / 10;
    }
if (n >= 0 && n < 10)
    {
    Console.Write(n);
    }
else
    {
    Console.Write("Введённое число не является натуральным");
    }