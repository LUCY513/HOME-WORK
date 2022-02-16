// 26. Возведите число А в натуральную степень B используя цикл
// Степень это 3^4 = 3 * 3 * 3 * 3 

double GetNumber()
{
    string input = Console.ReadLine();
    double.TryParse(input, out double num);
    return num;
}
int GetDegree()
{
    string input = Console.ReadLine();
    int.TryParse(input, out int num);
    return num;
}
Console.Write("Введите число: ");
double number = GetNumber();

Console.Write("Введите степень натурального числа: ");
int degree = GetDegree();

double result = 1;
for (int i = 1; i <= degree; i++)
    Console.WriteLine($"{i}. Число {number}^({degree}) = {result = result * number}");