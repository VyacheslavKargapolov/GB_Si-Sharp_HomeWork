/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/

Console.Clear();
Console.WriteLine("Введите 2 числа: ");
Console.Write("a = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("b = ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"MAX = {numberA}, MIN = {numberB}");
}
else
{
    Console.WriteLine($"MAX = {numberB}, MIN = {numberA}");
}