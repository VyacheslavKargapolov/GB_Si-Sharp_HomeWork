/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

using System;
using static System.Console;

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void PrintArray(int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{String.Format("{0,2}", inArray[i, j])} ");
        }
        WriteLine();
    }
}

void PrintElement(int[,] inArray, int i, int j)
{
    if ( i > inArray.GetLength(1) || j> inArray.GetLength(0))
    {
        WriteLine($"Элемента с индексом [{i},{j}] нет!!!");
    } 
    else  WriteLine($"Значение элемента с индексом [{i},{j}] равно {inArray[i-1,j-1]}");
}

Clear();
Write("Введите число столбцов n: ");
int n = Convert.ToInt32(ReadLine());
Write("Введите число строк m: ");
int m = Convert.ToInt32(ReadLine());
int[,] array = GetArray(m, n, -5, 5);
WriteLine();
PrintArray(array);
WriteLine();

WriteLine("Введите индексы элемента: ");
WriteLine("!!!Внимание первый элемент в первой строке имеет индекс [1, 1] ");
Write("строка = ");
int i = Convert.ToInt32(ReadLine());
Write("столбец = ");
int j = Convert.ToInt32(ReadLine());
WriteLine();
PrintElement(array, i, j);