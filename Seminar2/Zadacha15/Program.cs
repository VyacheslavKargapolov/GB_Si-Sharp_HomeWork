// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите номер дня недели: ");
int num_day = int.Parse(Console.ReadLine());

if (num_day == 6 || num_day == 7){
    Console.WriteLine($"{num_day} -ой день недели выходной");
}
else{
    Console.WriteLine("Это рабочий день");
}