int[,] CreateMatrix(int row, int column) // функция по созданию матрицы
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}
void ShowMatrix(int[,] matrix) // функция по выводу матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
double[] CheckMatrix(int[,] matrix) // функция по решению задачи: нахождение среднего арифметического чисел строк матрицы и занесение их в массив
{
    double sum = 0;
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        array[i] = sum / matrix.GetLength(1);
        sum = 0;
    }
    return array;
}

int[,] table = CreateMatrix(3, 4); // создание матрицы исходной
ShowMatrix(table); // вывод этой матрицы
double[] result = CheckMatrix(table); // создание переменной, в которую попадает результат работы функции
foreach (double e in result)
{
    Console.Write($"{e} ");
} // вывод ответа