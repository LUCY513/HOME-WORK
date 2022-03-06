// 67. Показать натуральные числа от N до M, N и M заданы (Рекурсия)

int num1 = GetNumber();
int num2 = GetNumber();

string num3 = NumberRec(num1, num2);

Console.Write($"{num3} ");


int GetNumber()
{
    Console.Write("Ведите натуральное число: ");
    string str = Console.ReadLine();
    int.TryParse(str, out int num);
    return num;
}

string NumberRec(int nm1, int nm2)                                       // Рекурсия 
{
    if (nm1 <= nm2) 
        return ($"{nm1} {NumberRec(nm1 + 1, nm2)}");         // 
    
    else return String.Empty;
}