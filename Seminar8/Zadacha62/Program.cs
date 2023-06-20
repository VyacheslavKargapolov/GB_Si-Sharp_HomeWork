/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using System;
using static System.Console;
Clear();
int m = 5;
int n = 5;

int[,] GetArray(int a, int b)
{
    int[,] result = new int[a, b];
    int i = 0;
    int j = 0;
    int rowEnd = a - 1;
    int columnEnd = b - 1;
    int rowStart = 0;
    int columnStart = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < a * b)
    {
        count++;
        result[i, j] = count;
        //начинаем вправо от [0,0]
        if (left && top)
        {
            if (j == columnEnd)
            {
                rowStart++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        //шаги вниз
        if (!left && top)
        {
            if (i == rowEnd)
            {
                columnEnd--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        //шаги влево
        if (!left && !top)
        {
            if (j == columnStart)
            {
                rowEnd--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        //шаги вверх
        if (left && !top)
        {
            if (i == rowStart)
            {
                columnStart++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }

    }
    return result;
}



void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j], 3} ");
        }
        WriteLine();
    }
}

PrintArray(GetArray(m, n));
 WriteLine();
