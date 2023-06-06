/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

                //метод создание массива чисел
                //преобразуем строку из чисел в массив 
                //затем преобразуем каждый элемент из строкового типа в тип вещественных чисел


double[] GetArrayFromString(string stringArray)
{
string[] nums = stringArray.Split(" ");
double[] res = new double[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
res[i] = double.Parse(nums[i]);
}
return res;
}

               //метод определения разницы между max и min
double RaznostElements(double[] Arr)
{
    double min = Arr[0];
    double max = Arr[1];
    for (int i =2; i<Arr.Length; i++)
    {
        if (Arr[i] > max)
        {
            max=Arr[i];
        }
        else
        {
            if (Arr[i] < min) min = Arr[i];
        }

    }
    double raznost = max - min;
    Console.WriteLine($"MAX = {max}, MIN = {min}");
    return raznost;
}


Console.Clear();
Console.Write("Введите элементы массива c запятой через пробел  (пример: 5,6 8 1,02): "); // пример 1,0 2,8 5,6
string elements = Console.ReadLine();


double[] array = GetArrayFromString(elements); // создание массива из метода
Console.WriteLine();
Console.WriteLine($"[{String.Join("; ", array)}]"); // вывод созданного массива
Console.WriteLine();
double rez = RaznostElements(array);
Console.WriteLine();
Console.WriteLine($"Разность между MAX и MIN = {rez:f3}");