// 30. Показать кубы чисел, заканчивающихся на четную цифру

double GetNumber()
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine();
    double.TryParse(input, out double num);
    return num;
}

double X = GetNumber();

double result = 1;

for (double i = 1; i <= X; i++)
{
    result = i * i * i;
    if (result % 2 == 0)
        Console.WriteLine($"{i}. {i}^({3}) = {result}");
    else Console.WriteLine($"{i}. Не четное");
}

