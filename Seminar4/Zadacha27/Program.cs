//Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int MathPow(int b)
{
    int sum = 0;
    int i = 0;
    while (b/10 > 0)
    {
        i = b % 10;
        sum = sum + i;
        b = b / 10;
    }
    sum =sum + b%10;
    return sum; 
}

Console.Clear();
Console.Write("введите число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"сумма цифр числа {num} равна {MathPow(num)}");
