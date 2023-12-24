Console.Write("Введите трёхзначное число, а я выдам первую и последнюю цифры: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(a / 100 * 10 + a % 10);