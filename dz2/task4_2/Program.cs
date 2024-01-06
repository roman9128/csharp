//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
Console.Write("Введите натуральное число, а я покажу его цифры: ");
int n = int.Parse(Console.ReadLine()!);
int nrev = 0;
if (n < 0)
    {
    Console.Write("Введённое число не является натуральным");
    }
else if (n >= 0 && n < 10)
    {
    Console.Write(n);
    }
else if (n >= 10 && n % 10 == 0)
    {
    n++;
    while (n > 0)
    {
    nrev = (nrev * 10) + (n % 10);
    n = n / 10;
    }
    while (nrev >= 10)
    {
    Console.Write(nrev % 10 + ", ");
    nrev = nrev / 10;
    }
    Console.Write(nrev-1);
    }
else if (n > 10 && n % 10 != 0)
    {
    while (n > 0)
    {
    nrev = (nrev * 10) + (n % 10);
    n = n / 10;
    }
    while (nrev >= 10)
    {
    Console.Write(nrev % 10 + ", ");
    nrev = nrev / 10;
    }
    Console.Write(nrev);
}