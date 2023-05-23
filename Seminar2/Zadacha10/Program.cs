//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
int result = new Random().Next(100, 1000);
Console.WriteLine(result);
int result1=result / 10;
int result2=result1 % 10;
Console.WriteLine($"{result2}");
