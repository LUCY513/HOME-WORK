// 69. Найти сумму элементов от M до N, N и M заданы (Рекурсия)


int num1 = GetNumber();
int num2 = GetNumber();

int num3 = NumberRec(num1, num2);

Console.Write($"{num3}");


int GetNumber()
{
    Console.Write("Ведите натуральное число: ");
    string str = Console.ReadLine();
    int.TryParse(str, out int num);
    return num;
}

int NumberRec(int nm1, int nm2)                                       // Рекурсия 
{
    int sum = 0;
    if (nm1 <= nm2) return sum += nm1 + NumberRec(nm1 + 1, nm2);
    else return 0;
}