// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//  http://study.sfu-kras.ru/DATA/docs/ProgramTheory/recurs/fun_akkr.htm
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;
Clear();
Write("Введите число M: ");
int M = int.Parse(ReadLine());
Write("Введите число N: ");
int N = int.Parse(ReadLine());

WriteLine(Akkerman(M, N));

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}