// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые не пересекаются, т.к. не пареллельны");
    else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые полностью совпадают");
    else Console.WriteLine($"Прямые пересекаются, точка пересечения имеет координаты ({x};{y})");
}

Console.WriteLine("Введите значение b1, k1, b2, k2, после каждого нажмите Enter: ");
double b1 = double.Parse(Console.ReadLine()!);
double k1 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);
double k2 = double.Parse(Console.ReadLine()!);

Intersection(b1, k1, b2, k2);

