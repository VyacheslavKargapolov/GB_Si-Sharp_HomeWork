// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a / 100 == 0)
{
    Console.WriteLine($"{a} третьей цифры нет");
}
else
{while (a / 1000 != 0){

    a = a / 10;
}
Console.WriteLine($"третья цифра {a % 10}");
}
