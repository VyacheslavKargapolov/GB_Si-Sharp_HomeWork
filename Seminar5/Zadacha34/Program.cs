/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

                //метод создание массива трехзначных чисел

int[] GetArray(int size)
{
    int[] arr = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;

}

                //метод подсчета четных элементов
int SumChetElements(int[] Arr)
{
    int count = 0;
    foreach (int el in Arr)
    {
        if (el%2 ==0)
        count++;
    }
    return count;
}

                //основная программа

Console.Clear();
Console.Write("Укажите размер массива: ");
int size_Arr = int.Parse(Console.ReadLine());
int[] array = GetArray(size_Arr); // создание массива из метода
int rezult = SumChetElements(array); // получили сумму четных элементов в массиве array

Console.WriteLine($"[{String.Join(", ", array)}]"); // вывод созданного массива
Console.WriteLine();
Console.WriteLine($"Четных эллементов в массиве {rezult}");
Console.WriteLine();
