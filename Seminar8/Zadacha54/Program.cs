/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns,-10, 10);
PrintArray(array);
WriteLine();

//SortedRow(array);
WriteLine();

int[,] GetArray(int m, int n, int min, int max) //метод создает двумерный массив
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)  //метод выводит двумерный массив
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 3} ");
        }
        WriteLine();
    }
}

void SortedRow(int[,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           
                int k = inArray[i, j+1];
                if (inArray[i, j] < k)
                {
                    int l = inArray[i, j];
                    inArray[i, j] = k;
                    k = l;
                    Write(inArray[i,j]);
                }
               
        WriteLine();
        }
    }
}
