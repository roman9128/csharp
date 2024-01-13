// Программа для изменения знака числа

int[] arr = { -10, 1, 9, 6, 0, -4, -8, 5, 10, 7 };
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i] * -1} ");
}

// другой вариант
//int[] arr2 = { -10, 1, 9, 6, 0, -4, -8, 5, 10, 7 };
//for (int i = 0; i < arr2.Length; i++)
//{
//    arr2[i] = arr2[i] * -1;
//    Console.Write($"{arr2[i]} ");
//}