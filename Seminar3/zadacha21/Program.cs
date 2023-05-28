/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Введём обозначения:
r1=(x1,y1,z1} — радиус-вектор первой точки;
r2=(x2,y2,z2)} — радиус-вектор второй точки;
d12 — расстояние между первой и второй точками.
d12 = abs(r2 - r1) ----> sqr((x2-x1)^2+(y2 - y1)^2+(z2 - z1)^)
*/

Console.Clear();
Console.WriteLine("Введите координаты первой точки:");
Console.Write("Х1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Z1 = ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("Х2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y2 = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Z1 = ");
int z2 = int.Parse(Console.ReadLine());

double s = Math.Sqrt((Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2)));
//Console.WriteLine($"Расстояние между точками {Math.Round(s, 4)}"); // округляем до 4 знаков после запятой
Console.WriteLine($" Расстояние между точками {s:f2}"); // так же производим округление до указанного числа знаков после запятой