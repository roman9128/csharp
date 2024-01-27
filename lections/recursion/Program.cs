int FindFactorial(int number)
{
    if (number == 1 || number == 0)
    {
        return 1;
    }
    return number * FindFactorial(number - 1);
}
Console.WriteLine(FindFactorial(3));