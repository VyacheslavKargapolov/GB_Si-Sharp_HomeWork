// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
using System;
using static System.Console;
Clear();

Write("Введите количество строк M: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов N: ");
int n = int.Parse(ReadLine());

int[,] array = GetArray(m, n);
PrintArray(array);

WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-5, 10);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");
        }
        WriteLine();
    }
}
int GetRowNumber (int [,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i<array.GetLength(1); i++)
    {
        minsum = minsum + array[0,i];
    }

    for (int i = 1; i<array.GetLength(0); i++)
    {
        int sum = 0; 
        for (int j = 0; j<array.GetLength(1); j++)
        {
            sum = sum+array[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}
