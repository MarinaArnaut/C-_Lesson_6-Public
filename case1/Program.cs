// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void CountNumb(string[] ListNum)
{
    int count = 0;
    Console.Write("Введен ряд чисел: ");
    foreach (string elem in ListNum)
    {
        if (int.Parse(elem) > 0)
            count++;
        Console.Write($"{elem} ");
    }
    Console.WriteLine($"\nКоличество чисел > 0 = {count}");
}
Console.WriteLine("Введите произвольный список целых чисел через пробел: ");
string[] list = (Console.ReadLine()!).Split(' ', ',');
CountNumb(list);
