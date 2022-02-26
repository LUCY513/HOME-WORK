// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
//  y1 = k1 * x + b1 
//  y2 = k2 * x + b2
//  y = k1 * x + b1 = k2 * x + b2

int k1 = RandomNum();
int b1 = RandomNum();
int k2 = RandomNum();
int b2 = RandomNum();

Console.WriteLine($"Заданы точки:\nk1 = {k1}\nb1 = {b1}\nk2 = {k2}\nb2 = {b2}");

Crossing();

int RandomNum()
{
    int number = new Random().Next(1, 100);
    return number;
}

void Crossing() // Пересечения
{
    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    Console.WriteLine($"x = {x}");
    if (k1 == k2)
        Console.WriteLine("Точки пересечения нет!");
    else
        Console.WriteLine($"Точка перечечения прямых:\ny1 = k1 * x + b1 и y2 = k2 * x + b2\nравна точке {x} и {y1} ");
}
