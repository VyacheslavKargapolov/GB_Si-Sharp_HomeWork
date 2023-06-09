﻿/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using System;
using static System.Console;

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(maxValue - minValue) + minValue;
        }
    }
    return result;
}



void PrintArray(double [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            double a = Math.Round(inArray[i,j], 2);
            //Write($"{inArray[i, j]:f1}");
            Write($"{String.Format("{0,5}", a)} ");
        }
        WriteLine();
    }
}

Clear();
WriteLine("Введите число столбцов n: ");
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите число строк m: ");
int m = Convert.ToInt32(ReadLine());
double[,] array = GetArray(m, n, -2, 3);
PrintArray(array);
WriteLine();