// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("<<Находим немер четверти>>");

int CoordinatX()
{
    Console.WriteLine("Допустимый диапозон координат от -10 до 10");
    Console.WriteLine("Введите точку координат X: ");
    string number = Console.ReadLine();
    int.TryParse(number, out int coordinata);
    return coordinata;
}
int CoordinatY()
{
    Console.WriteLine("Допустимый диапозон координат от -10 до 10");
    Console.WriteLine("Введите точку координат Y: ");
    string number = Console.ReadLine();
    int.TryParse(number, out int coordinata);
    return coordinata;
}

void Proces(int x, int y)
{
    if (x == 0 && y == 0)
        Console.WriteLine("Вы на оси координат в точке 0");
    if (x > 0 && y > 0)
        Console.WriteLine("Вы в I четверть");
    if (x < 0 && y > 0)
        Console.WriteLine("Вы в II четверть");
    if (x < 0 && y < 0)
        Console.WriteLine("Вы в III четверть");
    if (x > 0 && y < 0)
        Console.WriteLine("Вы в IV четверть");
}

int X = CoordinatX();
int Y = CoordinatY();

Proces(X, Y);
