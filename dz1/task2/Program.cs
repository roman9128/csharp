﻿using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
        // Введите свое решение ниже
        int result = a;
        if (a > b)
        { result = a; }
        else
        { result = b; }
        if (result > c)
        { return result; }
        else { return c; }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 3;
           b = 2;
           c = 1;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}