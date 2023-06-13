/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
            int a = inArray[i,j];
            //Write($"{inArray[i, j]:f1}");
            Write($"{String.Format("{0,5}", a)} ");
        }
        WriteLine();
    }
}

void SredneeArifmeticheskoe(int [,] inArray)
{
    
    double b = Convert.ToDouble(inArray.GetLength(0));
     for (int j = 0; j < inArray.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
           
        }
        double rez = Convert.ToDouble(sum);
        
        Write($"столбец {j+1} ---> ");
        WriteLine($"{(rez / b):f2} ");
    }

}



Clear();
WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите число строк: ");
int m = Convert.ToInt32(ReadLine());
int[,] array = GetArray(m, n, 0, 11);
PrintArray(array);
WriteLine();

WriteLine($"Среднее арифметическое: ");
SredneeArifmeticheskoe(array);