double Calculation(double a, double b, double c, double d)
{
    double result = (a * b) / (c + d);
    return result;
}

double result = Calculation(1, 2, 3, 4);
Console.Write(result);