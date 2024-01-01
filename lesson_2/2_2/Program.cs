Console.Write("Введите трёхзначное число, а я выдам второе число в степени, равной третьему числу: ");
int a = int.Parse(Console.ReadLine()!);
int a2 = (a / 10 % 10);
int a3 = (a % 10);
Console.WriteLine(Math.Pow(a2, a3));