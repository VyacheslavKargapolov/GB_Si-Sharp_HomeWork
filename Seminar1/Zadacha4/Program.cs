/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/
Console.Clear();
Console.WriteLine("Введите 3  числа: ");
Console.Write("a = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("b = ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("c = ");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine($"MAX = {numberA}");
    }
    else
    {
        Console.WriteLine($"MAX = {numberC}");
    }
}
else
{
    if (numberB > numberC)
    {
        Console.WriteLine($"MAX = {numberB}");
    }
    else
    {
        Console.WriteLine($"MAX = {numberC}");
    }
}