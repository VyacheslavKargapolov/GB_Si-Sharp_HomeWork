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

Clear();
Write("Введите количество строк M: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов N: ");
int n = int.Parse(ReadLine());

int[,] array = GetArray(m, n,10, 100);
PrintArray(array);
WriteLine();

int[,] SortArray = SortedRow(array);
PrintArray(SortArray);
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

int[,] SortedRow(int[,] arr) //Сортировка строк
{
    for (int y = 0; y < arr.GetLength(0) * arr.GetLength(1); y++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int k = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = k;
                }
            }
        }
    }
    return arr;
}
