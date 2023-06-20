/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using System;
using static System.Console;
Clear();
Write("Введите количество строк первой матрицы M: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов первой матрицы N: ");
int n = int.Parse(ReadLine());
Write("Введите количество строк второй матрицы K: ");
int k = int.Parse(ReadLine());
Write("Введите количество столбцов второй матрицы L: ");
int l = int.Parse(ReadLine());

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);
WriteLine();

int[,] array2 = GetArray(k, l, -5, 6);
PrintArray(array2);
WriteLine();



if(m != l) //если количество строк первой матрицы не равно количеству столбцов второй матрицы, то сколярное произведение матриц не определено
{
    WriteLine("Нельзя найти произведение таких матриц");
}
else 
{
    WriteLine("Произведение матриц");
    PrintArray(GetRezultArray(array, array2));
}

int[,] GetArray(int a, int b, int minValue, int maxValue)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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
            Write($" {arr[i, j], 3} ");
        }
        WriteLine();
    }
}
WriteLine();



int [,] GetRezultArray(int [,] arr, int [,] arr2)
{
    int [,] result = new int [arr.GetLength(0), arr2.GetLength(1)];
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr2.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(1);k++)
            {
                result [i,j] += arr[i,k] * arr2[k, j];
            } 
        }
    }
    return result;
}
