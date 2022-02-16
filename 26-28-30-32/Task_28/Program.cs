// 28. Подсчитать сумму цифр в числе

int GetNumber()
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine();
    int.TryParse(input, out int number);
    return number;
}

int num = GetNumber();
int result = 0;
while( num > 0)
{
    result += num % 10;
    num /= 10;
}
Console.WriteLine($"Сумма цифр числа {result}");