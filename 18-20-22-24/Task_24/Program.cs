// 24. Найти кубы чисел от 1 до N

Console.WriteLine("<<Нахождение числа в 3-ей степени>>");
int InPut()
{
    Console.Write("Введите натуральное число: ");
    string input = Console.ReadLine();
    int.TryParse(input, out int num);
    return num;
}
int X = InPut();

int result = X * X * X;
Console.WriteLine($"Число {X} в 3-ей степени равняеться {result}");