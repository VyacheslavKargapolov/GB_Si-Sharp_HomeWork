/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/
Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int num = 2;
while (num <= N)
{
    Console.Write($"{num} "); 
    num +=2;
}
Console.WriteLine($" ");