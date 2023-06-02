//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int MathPow(int a, int b)
{
    int rez = a;
    for(int i = 1; i != b; i++)
    {
        rez = rez * a;
    }
    return rez;
}

Console.Clear();
Console.Write("vvedite chislo A: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("vvedite chislo B: ");
int numB = int.Parse(Console.ReadLine()!);

if (numB < 0) 
{
    Console.WriteLine($"ukazhite znachenie stepeni (cislo B) > 0");
}

Console.WriteLine($"chislo {numA} v stepeni {numB} ravno {MathPow(numA, numB)}");
