﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

int NumberToThePower(int a)
{
    int result = 1;
    int count = 1;
    while ( count <= b)
    {
        result *= a;
        count++;
    }
  return(result);
}

Console.WriteLine(NumberToThePower(a));