// Задача 66
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
Write("Введите первое число M: ");
int m = int.Parse(ReadLine());
Write("Введите второе число N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine();

WriteLine($"Сумма натуральных чисел на отрезке [{m},{n}] = {Sum(m, n)}");

int Sum (int m, int n)
{
    if(m == n)
        return n;
    return (m + Sum(m + 1, n));
}
WriteLine();
