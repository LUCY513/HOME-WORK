// 22. Найти расстояние между точками в пространстве 2D/3D

// Пространство 2D - это A (X, У) - √((x1 - x2)^2 + (y1 - y2)^2) = √A = A

// Пространство 3D - это A (Х, У, Z) - √((x1 - x2)^2 + (y1 - y2)^2 + (z1 - z2)^2) = √A = A
// √a = a^2    √16 = 4^2 = 4 * 4 - из Корня нельзя извлекать отрицательные числа
Console.WriteLine("<<Находим растояние между точками в пространстве>>");

double CoordinatsX()
{
    Console.WriteLine("Введите число в диапазоне от -10 до 10");
    Console.Write("Введите точку X1: ");
    string input = Console.ReadLine();
    double.TryParse(input, out double number);
    return number;
}
double CoordinatsY()
{
    Console.WriteLine("Введите число в диапазоне от -10 до 10");
    Console.Write("Введите точку Y1: ");
    string input = Console.ReadLine();
    double.TryParse(input, out double number);
    return number;
}
double CoordinatsX2()
{
    Console.WriteLine("Введите число в диапазоне от -10 до 10");
    Console.Write("Введите точку X2: ");
    string input = Console.ReadLine();
    double.TryParse(input, out double number);
    return number;
}
double CoordinatsY2()
{
    Console.WriteLine("Введите число в диапазоне от -10 до 10");
    Console.Write("Введите точку Y2: ");
    string input = Console.ReadLine();
    double.TryParse(input, out double number);
    return number;
}

double X1 = CoordinatsX();
double Y1 = CoordinatsY();

double X2 = CoordinatsX2();
double Y2 = CoordinatsY2();

double result = ((X1 - X2) * (X1 - X2)) + ((Y1 - Y2) * (Y1 - Y2));

Console.WriteLine(Math.Sqrt(result));