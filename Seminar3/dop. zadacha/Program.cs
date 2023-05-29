/*На столе лежат n монеток. Некоторые из них лежат вверх решкой,
а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
чтобы все монетки были повернуты вверх одной и той же стороной.
1-Решка
0-Орел */


Console.Clear();
Console.Write("Укажите количество монет: ");
int N = int.Parse(Console.ReadLine());
                                    //Проверяем, что монеты есть.
while (N <= 0)
{
    Console.WriteLine("Хитрец! Иди, поищи монеты и возвращайся...");
    Console.WriteLine();
    Console.WriteLine("- Нашел?! Хорошо");
    Console.Write("Укажите количество монет: ");
    N = int.Parse(Console.ReadLine());

}

                                    //Создаем массив длиной N, в котором элементы примут значения рандомно 1 или 0
int [] arrey = new int [N];
for (int i = 1; i <N; i++)
{
    arrey[i-1] = new Random().Next(0, 2);
}

                                    // Выводим на экран все элементы массива
Console.WriteLine();
Console.WriteLine("Бросаем монеты на стол... ");
Console.WriteLine();
for (int i = 0; i <N; i++)
{
    Console.Write($"{arrey[i]} ");
}
Console.WriteLine();
Console.WriteLine();

                                    //Считаем сколько элементов массива имеют значение 0, а сколько 1
int Sum_0 = 0;
int Sum_1 = 0;
for (int i = 0; i < N; i++)
{
    if (arrey[i] == 0)
        Sum_0++;
    else
        Sum_1++;
}
Console.WriteLine();

                                    //Выводим количество значений 0-ОРЕЛ и 1-РЕШКА
Console.WriteLine($"Выпал ОРЕЛ на {Sum_0} монетах(е))!");
Console.WriteLine($"Выпала РЕШКА на {Sum_1} монетах(е))!");
Console.WriteLine();

                                    //Отвечаем на вопрос: минимальное число монеток, которые нужно перевернуть,
                                    //чтобы все монетки были повернуты вверх одной и той же стороной.
if (Sum_0 > Sum_1)
    Console.WriteLine($"Необходимо перевернуть {Sum_1} монет(у)");
else
    Console.WriteLine($"Необходимо перевернуть {Sum_0} монет(у)");