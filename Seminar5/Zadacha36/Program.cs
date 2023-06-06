 /*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
 
                //метод создание массива трехзначных чисел

int[] GetArray(int size)
{
    int[] arr = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}

                //метод подсчета sum элементов на нечетных позициях
int SumElements(int[] Arr)
{
    int Sum = 0;
    for (int i =1; i<Arr.Length; i+=2)
    {
        Sum += Arr[i];
    }
    return Sum;
}


                //основная программа

Console.Clear();
Console.Write("Укажите размер массива: ");
int size_Arr = int.Parse(Console.ReadLine());
int[] array = GetArray(size_Arr); // создание массива из метода
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}]"); // вывод созданного массива

int rezult = SumElements(array); // получили сумму элементов на нечетных позициях в массиве array
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях в массиве {rezult}");
Console.WriteLine();