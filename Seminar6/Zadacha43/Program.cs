/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();
Console.WriteLine("Введите коэфициенты k1, b1, k2, b2:");
Console.WriteLine();
Console.Write("k1= ");
double k1= double.Parse(Console.ReadLine());
Console.Write("b1= ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("k2= ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2= ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine();

if (k1 == k2) Console.WriteLine($"Прямые не пересекаются!!!");
else
{
    double[] rez =  M_Point(k1, b1, k2, b2);
    Console.WriteLine($"Координаты точки пересечения прямых М = [{rez[0]:f1} : {rez[1]:f1}]");
    Console.WriteLine();
}

//Метод ищем координаты точки пересечения. х и у - элементы массива

double[] M_Point(double pk1, double pb1, double pk2, double pb2)
{
    double[] array = new double[2];
    array[0] = (pb2 - pb1) / (pk1 - pk2);
    array[1] = pk2 * array[0] + pb2;
    return array;
}
