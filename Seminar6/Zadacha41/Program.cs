/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] GetArrayFromString(string stringArray)
{
string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] res = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
res[i] = Convert.ToInt32(nums[i]);
}
return res;
}

int CountPozitivElement(int[] arr)
{
    int count = 0;
    for(int i=0; i < arr.Length; i++)
        if (arr[i] >= 0) count++;
    return count;
}


Console.Clear();
Console.Write("Введите числа через пробел: ");
string elements = Console.ReadLine();
int[] array = GetArrayFromString(elements);
Console.WriteLine();
int rez = CountPozitivElement(array);
Console.WriteLine($"Количество положительных чисел: {rez}");
Console.WriteLine();
