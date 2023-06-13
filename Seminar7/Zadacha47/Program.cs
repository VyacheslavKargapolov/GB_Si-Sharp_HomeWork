/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using System;
using static System.Console;
double [,] array = new double [3, 3];
int minValue = -2;
int maxValue = 5;
void GetArray(double[,] InArr)
{
    for (int i =0; i<InArr.GetLength(0); i++)
    {
        for(int j=0; j<InArr.GetLength(1); j++)
        {
            InArr[i, j] = new Random().NextDouble() * (maxValue-minValue)+minValue;
            Write($"{InArr[i, j]:f2} ");
        }
        WriteLine();
    }
    WriteLine();
}

GetArray(array);