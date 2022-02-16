// 7. Показать числа от -N до N

Console.Write("Введите натуральное число: ");
string input = Console.ReadLine();
int num = int.Parse(input);
int min = -1 * num;
int max = num;

while (min <= max)
{
    Console.Write($" {min++}");
}
