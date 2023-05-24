// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
long a = long.Parse(Console.ReadLine());


if (Math.Abs(a) / 100 == 0)
{
    Console.WriteLine($"{a} третьей цифры нет");
}
else
{while (Math.Abs(a) / 1000 != 0){

    a = Math.Abs(a) / 10;
}
Console.WriteLine($"третья цифра {a % 10}");
}
